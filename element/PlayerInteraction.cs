// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt
// Each Round consists of 1. Player Movement 2. Player Action

using System.Runtime.CompilerServices;

namespace project {
    class PlayerInteraction {
        public static void listElements() {
            if (Program.current != null) {
                List<Element> elements = Program.current.elements.elements;

                Logger.Empty();
                Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.DarkMagenta);
                Logger.Empty();

                List<string> valid = new List<string>();

                if (elements.Count > 0) {
                    foreach(Element element in elements) {
                        Logger.DefaultMessage("Room contains "+element.name+"!", ConsoleColor.DarkMagenta) ;
                        valid.Add(element.name.ToLower());
                    }
                } else {
                    Logger.DefaultMessage("Room is Empty!", ConsoleColor.DarkMagenta) ;
                }
                

                Logger.Empty();
                Logger.DefaultMessage("Input the Name of an Element to Interact with it!", ConsoleColor.DarkMagenta);
                Logger.Empty();
                Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.DarkMagenta);
                string? input = GetInput("Please select an Element: ", valid);

                foreach(Element element in elements) {
                    if (element.name.ToLower() == input) {
                        Logger.Empty();
                        if (element.items.items.Count > 0) {
                            foreach (Item item in element.items.items) {
                                Logger.DefaultMessage(element.name + " contains "+item.name+"!", ConsoleColor.DarkMagenta);
                            }
                        } else {
                            Logger.DefaultMessage(element.name+" is Empty!", ConsoleColor.DarkMagenta);
                        }

                        List<string> validAction = new List<string> {
                            "leave",
                        };
                        Logger.Empty();
                        Logger.DefaultMessage("Input LEAVE to go back to the Main Screen!", ConsoleColor.DarkMagenta);
                        if (element.items.items.Count > 0) {
                            validAction.Add("take");
                            Logger.DefaultMessage("Input TAKE to take the Items!", ConsoleColor.DarkMagenta);
                        }
                        Logger.Empty();
                        Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.DarkMagenta);
                        string? inputAction = GetInput("Please select an action: ", validAction);

                        switch(inputAction) {
                            case "leave": {
                                break;
                            }
                            case "take": {
                                element.take();
                                break;
                            }
                        }

                        break;
                    }
                }
            }
        }

        public static string? GetInput(String msg, List<string> valid) {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("");
            Console.WriteLine(msg);

            string? output = null;

            while (output == null) {
                output = Console.ReadLine(); 

                if (output != null && valid.Contains(output.ToLower())) {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("");
                    Console.WriteLine("Accepted!");
                    Logger.Empty();
                    Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.DarkMagenta);
                    return output.ToLower();
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input, try again:");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    output = null;
                }
            }

            Console.ForegroundColor = default;

            return default;
        }
    }
}


