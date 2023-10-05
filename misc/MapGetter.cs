// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class MapGetter {
        public static void printMap(bool right, bool up, bool left, bool down) {
            if (right && left && up && down) {
                Logger.Empty();
                Logger.DefaultMessage("  __| |__  ", ConsoleColor.Green);
                Logger.DefaultMessage("_|       |_", ConsoleColor.Green);
                Logger.DefaultMessage("_    x    _", ConsoleColor.Green);
                Logger.DefaultMessage(" |__   __| ", ConsoleColor.Green);
                Logger.DefaultMessage("    | |    ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } 

            else if (!right && !left && up && !down) {
                Logger.Empty();
                Logger.DefaultMessage("  _______  ", ConsoleColor.Green);
                Logger.DefaultMessage(" |       | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |   x   | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |_______| ", ConsoleColor.Green);
                Logger.DefaultMessage("           ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            }
            
            else if (!right && left && up && down) {
                Logger.Empty();
                Logger.DefaultMessage("  __| |__  ", ConsoleColor.Green);
                Logger.DefaultMessage("_|       | ", ConsoleColor.Green);
                Logger.DefaultMessage("_    x   | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |__   __| ", ConsoleColor.Green);
                Logger.DefaultMessage("    | |    ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } else if (right && !left && up && down) {
                Logger.Empty();
                Logger.DefaultMessage("  __| |__  ", ConsoleColor.Green);
                Logger.DefaultMessage(" |       |_", ConsoleColor.Green);
                Logger.DefaultMessage(" |   x    _", ConsoleColor.Green);
                Logger.DefaultMessage(" |__   __| ", ConsoleColor.Green);
                Logger.DefaultMessage("    | |    ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } else if (right && left && !up && down) {
                Logger.Empty();
                Logger.DefaultMessage("  _______  ", ConsoleColor.Green);
                Logger.DefaultMessage("_|       |_", ConsoleColor.Green);
                Logger.DefaultMessage("_    x    _", ConsoleColor.Green);
                Logger.DefaultMessage(" |__   __| ", ConsoleColor.Green);
                Logger.DefaultMessage("    | |    ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } else if (right && left && up && !down) {
                Logger.Empty();
                Logger.DefaultMessage("  __| |__  ", ConsoleColor.Green);
                Logger.DefaultMessage("_|       |_", ConsoleColor.Green);
                Logger.DefaultMessage("_    x    _", ConsoleColor.Green);
                Logger.DefaultMessage(" |_______| ", ConsoleColor.Green);
                Logger.DefaultMessage("           ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            }
            
            else if (!right && !left && up && down) {
                Logger.Empty();
                Logger.DefaultMessage("  __| |__  ", ConsoleColor.Green);
                Logger.DefaultMessage(" |       | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |   x   | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |__   __| ", ConsoleColor.Green);
                Logger.DefaultMessage("    | |    ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } else if (right && left && !up && !down) {
                Logger.Empty();
                Logger.DefaultMessage("  _______  ", ConsoleColor.Green);
                Logger.DefaultMessage("_|       |_", ConsoleColor.Green);
                Logger.DefaultMessage("_    x    _", ConsoleColor.Green);
                Logger.DefaultMessage(" |_______| ", ConsoleColor.Green);
                Logger.DefaultMessage("           ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            }
            
            else if (!right && left && !up && down) {
                Logger.Empty();
                Logger.DefaultMessage("  _______  ", ConsoleColor.Green);
                Logger.DefaultMessage("_|       | ", ConsoleColor.Green);
                Logger.DefaultMessage("_    x   | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |__   __| ", ConsoleColor.Green);
                Logger.DefaultMessage("    | |    ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } else if (right && !left && !up && down) {
                Logger.Empty();
                Logger.DefaultMessage("  _______  ", ConsoleColor.Green);
                Logger.DefaultMessage(" |       |_", ConsoleColor.Green);
                Logger.DefaultMessage(" |   x    _", ConsoleColor.Green);
                Logger.DefaultMessage(" |__   __| ", ConsoleColor.Green);
                Logger.DefaultMessage("    | |    ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } else if (!right && left && up && !down) {
                Logger.Empty();
                Logger.DefaultMessage("  __| |__  ", ConsoleColor.Green);
                Logger.DefaultMessage("_|       | ", ConsoleColor.Green);
                Logger.DefaultMessage("_    x   | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |_______| ", ConsoleColor.Green);
                Logger.DefaultMessage("           ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } else if (right && !left && up && !down) {
                Logger.Empty();
                Logger.DefaultMessage("  __| |__  ", ConsoleColor.Green);
                Logger.DefaultMessage(" |       |_", ConsoleColor.Green);
                Logger.DefaultMessage(" |   x    _", ConsoleColor.Green);
                Logger.DefaultMessage(" |_______| ", ConsoleColor.Green);
                Logger.DefaultMessage("           ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } 
            
            else if (!right && !left && !up && down) {
                Logger.Empty();
                Logger.DefaultMessage("  _______  ", ConsoleColor.Green);
                Logger.DefaultMessage(" |       | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |   x   | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |__   __| ", ConsoleColor.Green);
                Logger.DefaultMessage("    | |    ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } else if (!right && !left && up && !down) {
                Logger.Empty();
                Logger.DefaultMessage("  __| |__  ", ConsoleColor.Green);
                Logger.DefaultMessage(" |       | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |   x   | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |_______| ", ConsoleColor.Green);
                Logger.DefaultMessage("           ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } else if (!right && left && !up && !down) {
                Logger.Empty();
                Logger.DefaultMessage("  _______  ", ConsoleColor.Green);
                Logger.DefaultMessage("_|       | ", ConsoleColor.Green);
                Logger.DefaultMessage("_    x   | ", ConsoleColor.Green);
                Logger.DefaultMessage(" |_______| ", ConsoleColor.Green);
                Logger.DefaultMessage("           ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } else if (right && !left && !up && !down) {
                Logger.Empty();
                Logger.DefaultMessage("  _______  ", ConsoleColor.Green);
                Logger.DefaultMessage(" |       |_", ConsoleColor.Green);
                Logger.DefaultMessage(" |   x    _", ConsoleColor.Green);
                Logger.DefaultMessage(" |_______| ", ConsoleColor.Green);
                Logger.DefaultMessage("           ", ConsoleColor.Green);
                Logger.Empty();
                Logger.DefaultMessage("x - Your Position", ConsoleColor.Green);
            } 
            
        }
    }
}


