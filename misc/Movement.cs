// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class Movement {
        public static void doMovement() {
            List<string> valid = new List<string>();

            if (Program.current != null) {
                Logger.Empty();
                Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("You are in "+ Program.current.name+"!", ConsoleColor.Green);
                MapGetter.printMap(Program.current.doorRight, Program.current.doorUp, Program.current.doorLeft, Program.current.doorDown);
                Logger.Empty();
                if (Program.current.doorUp) {
                    valid.Add("up");
                    Logger.DefaultMessage("Input UP to go upwards!", ConsoleColor.Green);
                }
                if (Program.current.doorDown) {
                    valid.Add("down");
                    Logger.DefaultMessage("Input DOWN to go downwards!", ConsoleColor.Green);
                }
                if (Program.current.doorLeft) {
                    valid.Add("left");
                    Logger.DefaultMessage("Input LEFT to go left!", ConsoleColor.Green);
                }
                if (Program.current.doorRight) {
                    valid.Add("right");
                    Logger.DefaultMessage("Input RIGHT to go right!", ConsoleColor.Green);
                }
                Logger.Empty();
                Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.Green);
                string? input = GetMoveInput("Please make your Input: ", valid);

                switch (input) {
                    case "up": {
                        Program.playerY++;
                        Program.current = Program.roomManager.Get(Program.playerX, Program.playerY);
                        break;
                    }

                    case "down": {
                        Program.playerY--;
                        Program.current = Program.roomManager.Get(Program.playerX, Program.playerY);
                        break;
                    }

                    case "right": {
                        Program.playerX++;
                        Program.current = Program.roomManager.Get(Program.playerX, Program.playerY);
                        break;
                    }

                    case "left": {
                        Program.playerX--;
                        Program.current = Program.roomManager.Get(Program.playerX, Program.playerY);
                        break;
                    }

                }
            }
        }

        public static string? GetMoveInput(String msg, List<string> valid) {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("");
            Console.WriteLine(msg);

            string? output = null;

            while (output == null) {
                output = Console.ReadLine(); 

                if (output != null && valid.Contains(output)) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("Accepted!");
                    Logger.Empty();
                    Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.Green);
                    return output.ToLower();
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input, try again:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    output = null;
                }
            }

            Console.ForegroundColor = default;

            return default;
        }
    }
}


