using System.Collections;
using System.Globalization;

namespace project {
    class MultiThreadingHelper {
        private static List<MultiThread> threads = new ();

        /// <summary>
        /// Opens a New Multithread object
        /// </summary>
        /// <param name="name">name of the Object</param>
        /// <returns>the Created Object</returns>
        public static MultiThread OpenMulti(String name) {
            MultiThread t = new MultiThread(name);
            threads.Add(t);
            return t;
        }

        /// <summary>
        /// Stops all Current MultiThreads
        /// </summary>
        public static void StopAll() {
            waitForAll();
            for (int I = 0; I < threads.Count; I++) {
                threads[I].Stop();
            }
        }

        /// <summary>
        /// Waits for a Thread to Finish
        /// </summary>
        /// <param name="name">name of the thread</param>
        public static void waitFor(String name) {
            for (int I = 0; I < threads.Count; I++) {
                if (threads[I].name == name) {
                    bool success = false;
                    while (!success) {
                        if (threads[I].timesRan == threads[I].FinishedRunnables.Count && threads[I].timesRan != 0) {
                            success = true;
                        }
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Wait for all Threads to finish
        /// </summary>
        public static void waitForAll() {
            for (int I = 0; I < threads.Count; I++) {
                bool success = false;
                while (!success) {
                    if (threads[I].timesRan == threads[I].FinishedRunnables.Count && threads[I].timesRan != 0) {
                        success = true;
                    }
                }
            }
        }
    }
    class MultiThread {

        public string name;
        public string startValue;

        public MultiThread(String name) {
            this.name = name;
            startValue = DateTime.Now.ToString(CultureInfo.CurrentCulture);
            worker = new (() => { while (generalRun) runAll();});
            Start();
        }

        public List<Action> Runnables = new ();
        public List<Action> FinishedRunnables = new ();

        private bool generalRun = true;

        public int timesRan;

        private Thread worker;

        /// <summary>
        /// Executes the Specified action
        /// </summary>
        /// <param name="runnable">the action</param>
        public Action Execute(Action runnable) {
            Runnables.Add(runnable);
            return runnable;
        }

        private void StopExecute(Action runnable) {
            Runnables.Remove(runnable);
        }

        private void Start() {
            worker.Start();
        }
        
        public void Stop() {
            generalRun = false;
            for (int I = 0; I < Runnables.Count; I++) {
                Action a = Runnables[I];
                StopExecute(a);
            }
            worker.Interrupt();
        }

        private void runAll() {
            if (Runnables.Count != 0) {
                for (int I = 0; I < Runnables.Count; I++) {
                    Action a = Runnables[I];
                    StopExecute(a);
                    a();
                    timesRan++;
                    FinishedRunnables.Add(a);
                }
            }
        }
    }
}