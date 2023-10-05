namespace project {
    class TextUtils {
        /// <summary>
        /// returns the Inputed String with messaging built in
        /// </summary>
        /// <param name="msg">the Message to Send</param>
        /// <returns>the Inputed String</returns>
        public static string? GetStringInput(String msg) {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("");
            Console.WriteLine(msg);

            string? input = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Accepted!");

            Console.ForegroundColor = default;

            return input;
        }

        /// <summary>
        /// retries getting the input until a Integer could be Parsed with messaging built in
        /// </summary>
        /// <param name="msg">the Message</param>
        /// <returns>the Parsed Integer value</returns>
        public static int? GetIntegerInput(String msg) {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("");
            Console.WriteLine(msg);

            int? output = null;

            while (output == null) {
                string? str = Console.ReadLine(); 
                bool success = int.TryParse(str, out int outputed);
                output = outputed;

                if (output != null && success && str != null) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Accepted!");
                    return output;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input, try again:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    output = null;
                }
            }

            Console.ForegroundColor = default;

            return default;
        }

        /// <summary>
        /// retries getting the input until a Double could be Parsed with messaging built in
        /// </summary>
        /// <param name="msg">the Message</param>
        /// <returns>the Parsed Double value</returns>
        public static double? GetDoubleInput(String msg) {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("");
            Console.WriteLine(msg);

            double? output = null;

            while (output == null) {
                string? str = Console.ReadLine(); 
                bool success = double.TryParse(str, out double outputed);
                output = outputed;
                if (output != null && success && str != null) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Accepted!");
                    return output;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input, try again:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    output = null;
                }
            }

            Console.BackgroundColor = default;
            Console.ForegroundColor = default;

            return default;
        }
    }
}