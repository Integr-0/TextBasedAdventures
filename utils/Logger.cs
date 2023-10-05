using System.Globalization;

namespace project {
    class Logger {
        /// <summary>
        ///  Prints a Normal Message
        /// </summary>
        /// <param name="str">The String to Print</param>
        public static void DefaultMessage(Object? str, ConsoleColor color) {
            Console.ForegroundColor = color;

            Console.WriteLine($"{str}");

            Console.ForegroundColor = default;
        }

        /// <summary>
        ///  Prints a Formatted Info Message
        /// </summary>
        /// <param name="obj">The Object to Print</param>
        public static void Info(Object? obj) {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"[{DateTime.Now.ToString(CultureInfo.CurrentCulture)}] - Info: {obj}");

            Console.ForegroundColor = default;
        }
       
        /// <summary>
        ///  Prints a Formatted Warning Message
        /// </summary>
        /// <param name="obj">The Object to Print</param>
        public static void Warn(Object? obj) {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"[{DateTime.Now.ToString(CultureInfo.CurrentCulture)}] - Warn: {obj}");

            Console.ForegroundColor = default;
        }

        /// <summary>
        ///  Prints a Formatted Error Message
        /// </summary>
        /// <param name="obj">The Object to Print</param>
        public static void Error(Object? obj) {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"[{DateTime.Now.ToString(CultureInfo.CurrentCulture)}] - Error: {obj}");

            Console.ForegroundColor = default;
        }

        /// <summary>
        ///  Prints a Formatted Info Message
        /// </summary>
        /// <param name="obj">The Object to Print</param>
        public static void InfoThread(Object? obj, MultiThread thread) {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"[{DateTime.Now.ToString(CultureInfo.CurrentCulture)}] - [Thread: {thread.name} - Started: {thread.startValue}] Info: {obj}");

            Console.ForegroundColor = default;
        }
       
        /// <summary>
        ///  Prints a Formatted Warning Message
        /// </summary>
        /// <param name="obj">The Object to Print</param>
        public static void WarnThread(Object? obj, MultiThread thread) {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"[{DateTime.Now.ToString(CultureInfo.CurrentCulture)}] - [Thread: {thread.name} - Started: {thread.startValue}] Warn: {obj}");

            Console.ForegroundColor = default;
        }

        /// <summary>
        ///  Prints a Formatted Error Message
        /// </summary>
        /// <param name="obj">The Object to Print</param>
        public static void ErrorThread(Object? obj, MultiThread thread) {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"[{DateTime.Now.ToString(CultureInfo.CurrentCulture)}] - [Thread: {thread.name} - Started: {thread.startValue}] Error: {obj}");

            Console.ForegroundColor = default;
        }

        /// <summary>
        /// Prints an Empty Line
        /// </summary>
        public static void Empty() {
            Console.WriteLine("");
        }

        /// <summary>
        /// Prints an Line Seperator Line
        /// </summary>
        public static void Seperator() {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("o------------------------------------------o");
            Console.ForegroundColor = default;
        }

        /// <summary>
        /// Prints Information about used Colors in consolle
        /// </summary>
        public static void ColorInfo() {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("o---------------<Color Info>---------------o");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Blue");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" - Awaiting User Input               |");
            Console.WriteLine("");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Red");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" - Error for Code Execution           |");
            Console.WriteLine("");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Yellow");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" - Warning for Code Execution      |");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("|");
            Console.Write(" Gray/White");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" - Normal Info                 |");
            Console.WriteLine("o------------------------------------------o");

            Console.ForegroundColor = default;
        }
    }
}