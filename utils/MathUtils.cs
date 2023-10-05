namespace project {
    class MathUtils {
        /// <summary>
        /// Get a Random Integer
        /// </summary>
        /// <returns>A random Integer</returns>
        public static int RandomInt() {
            return Random.Shared.Next();
        }

        /// <summary>
        /// Get a Random Negative Integer
        /// </summary>
        /// <returns>A random Negative Integer</returns>
        public static int RandomIntNegative() {
            return -Random.Shared.Next();
        }

        /// <summary>
        /// Get a Random Integer capped by the values min and max
        /// </summary>
        /// <param name="min">Minimum Value</param>
        /// <param name="max">Maximum Value</param>
        /// <returns>A random Integer capped by the values min and max</returns>
        public static int RandomIntFromRange(int min, int max) {
            return Random.Shared.Next(min, max);
        }

        /// <summary>
        /// Get the Specified Root of the specified value
        /// </summary>
        /// <param name="root">-Th Root</param>
        /// <param name="value">Value</param>
        /// <returns>The Specified Root of the specified value</returns>
        public static double Root(int root, double value) {
            return Math.Pow(root, 1.0 / value);
        }

        /// <summary>
        /// Get the Square Root of the specified value
        /// </summary>
        /// <param name="value">the Value</param>
        /// <returns>the Square Root of the specified value</returns>
        public static double SquareRoot(double value) {
            return Math.Sqrt(value);
        }

        /// <summary>
        /// Returns the SpecifiedValue Squared
        /// </summary>
        /// <param name="value">the Value</param>
        /// <returns>the Value Squared</returns>
        public static double Squared(double value) {
            return value*value;
        }

        /// <summary>
        /// Get the specified value raised by the power specified
        /// </summary>
        /// <param name="value">the Value</param>
        /// <param name="power">the Power</param>
        /// <returns>the specified value raised by the power specified</returns>
        public static double ToThePower(double value, double power) {
            return Math.Pow(value, power);
        }

        /// <summary>
        /// Returns the Solved Pythagoras Algorythm
        /// </summary>
        /// <param name="a">length of side a</param>
        /// <param name="b">length of side b</param>
        /// <returns>length of side c</returns>
        public static double Pythagoras(double a, double b) {
            return SquareRoot(Squared(a)+Squared(b));
        }

        /// <summary>
        /// Get Area of a Rectangle
        /// </summary>
        /// <param name="a">length of side a</param>
        /// <param name="b">length of side b</param>
        /// <returns>the Area</returns>
        public static double AreaRectangle(double a, double b) {
            return a*b;
        }

        /// <summary>
        /// Get the Perimeter of a Rectangle
        /// </summary>
        /// <param name="a">length of side a</param>
        /// <param name="b">length of side b</param>
        /// <returns>the Perimeter</returns>
        public static double PerimeterRectangle(double a, double b) {
            return 2*a+2*b;
        }

        /// <summary>
        /// Get the Area of a Circle
        /// </summary>
        /// <param name="radius">Radius of the Circle</param>
        /// <returns>the Area</returns>
        public static double AreaCircle(double radius) {
            return Math.PI*Squared(radius);
        }

        /// <summary>
        /// Get the Cirucmference of a Circle
        /// </summary>
        /// <param name="radius">Radius of the Circle</param>
        /// <returns>the Circumference</returns>
        public static double CircumferenceCircle(double radius) {
            return 2*Math.PI*radius;
        }

        /// <summary>
        /// Get the Area of a Triangle
        /// </summary>
        /// <param name="height">the height h of the Triangle</param>
        /// <param name="a">the base of the triangle (h is 90 degrees to the base)</param>
        /// <returns>the Area</returns>
        public static double AreaTriangle(double height, double a) {
            return 1/2*a*height;
        }
    }
}