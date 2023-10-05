namespace project {
    class RuntimeUtils {
        /// <summary>
        /// Makes the Code halt for the Specified time in Milliseconds
        /// </summary>
        /// <param name="Milliseconds">the Specified time</param>
        public static void Wait(int Milliseconds) {
            Thread.Sleep(Milliseconds);
        }

        /// <summary>
        /// Waits for the User to press any Key
        /// </summary>
        public static void AwaitUser() {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("");
            Console.WriteLine("Press any Key to Continue!");
            Console.ReadKey(true);

            Console.ForegroundColor = default;
        }

        /// <summary>
        /// Waits for the User to Press any Key and exitting Threads
        /// </summary>
        public static void AwaitUserExit() {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("");
            Console.WriteLine("Press any Key to Exit!");
            Console.ReadKey(true);

            MultiThreadingHelper.StopAll();

            Console.ForegroundColor = default;
        }

        /// <summary>
        /// Waits Until the Specified Key was pressed
        /// </summary>
        /// <param name="key">the key</param>
        public static void AwaitKey(ConsoleKey key) {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("");
            Console.WriteLine($"Press {key.ToString()} to Continue!");

            ConsoleKeyInfo info = Console.ReadKey(true);

            bool success = false;
            while (!success) {
                if (info.Key == key) {
                    success = true;
                } else {
                    info = Console.ReadKey(true);
                }
            }

            Console.ForegroundColor = default;
        }
    }
}