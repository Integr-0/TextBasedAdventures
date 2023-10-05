// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class Game {
        public static bool playing = true;
        public static void start() {
            while (playing) {
                mainDecision();
            }
        }

        public static void mainDecision() {
            Logger.Empty();
            Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.Blue);
            Logger.Empty();
            Logger.DefaultMessage("Input MOVE to make a Movement!", ConsoleColor.Blue);
            Logger.DefaultMessage("Input ELEMENT to interact with an Element!", ConsoleColor.Blue);
            Logger.DefaultMessage("Input MAP to see the Map!", ConsoleColor.Blue);
            Logger.DefaultMessage("Input EXITGAME to exit the Game!", ConsoleColor.Blue);
            Logger.DefaultMessage("Input INVENTORY to exit the Game!", ConsoleColor.Blue);
            Logger.Empty();
            Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.Blue);

            if (Program.current != null) {
                string? action = GetMainInput("Please Input Your Action: ");
                switch (action) {
                    case "move": {
                        Movement.doMovement();
                        break;
                    }

                    case "element": {
                        PlayerInteraction.listElements();
                        break;
                    }

                    case "map": {
                        Logger.Empty();
                        Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.Green);
                        Logger.Empty();
                        Logger.DefaultMessage("You are in "+ Program.current.name+"!", ConsoleColor.Green);
                        MapGetter.printMap(Program.current.doorRight, Program.current.doorUp, Program.current.doorLeft, Program.current.doorDown);
                        Logger.Empty();
                        Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.Green);
                        break;
                    }

                    case "exitgame": {
                        playing = false;
                        break;
                    }

                    case "inventory": {
                        Program.inventory.printAll();
                        break;
                    }
                }
            }
        }

        public static string? GetMainInput(String msg) {
            List<string> valid = new List<string> {
                "move",
                "element",
                "map",
                "exitgame",
                "inventory"
            };
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("");
            Console.WriteLine(msg);

            string? output = null;

            while (output == null) {
                output = Console.ReadLine(); 

                if (output != null && valid.Contains(output.ToLower())) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Accepted!");
                    Logger.Empty();
                    Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.Blue);
                    return output.ToLower();
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
    }
}


