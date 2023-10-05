// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class RoomGenerator {
        public static void generate(int x, int y) {
            if (Program.current != null && !Program.roomManager.Exists(x, y)) {
                bool newDoorRight = false;
                bool newDoorLeft = false;
                bool newDoorUp = false;
                bool newDoorDown = false;

                if (Program.roomManager.Exists(x-1, y) || getRanBool()) {
                    newDoorLeft = true;
                }
                if (Program.roomManager.Exists(x+1, y) || getRanBool()) {
                    newDoorRight = true;
                }
                if (Program.roomManager.Exists(x, y-1) || getRanBool()) {
                    newDoorDown = true;
                }
                if (Program.roomManager.Exists(x, y+1) || getRanBool()) {
                    newDoorUp = true;
                }

                Program.roomManager.rooms.Add(new Room(genName(), x, y, newDoorUp, newDoorDown, newDoorLeft, newDoorRight, ElementGenerator.getElementList()));
            }
        }

        public static List<string> names = new List<string>() {
            "Kitchen", "Bedroom", "Prison", "Normal Room", "Storage Room",
            "Weapons Room", "Testing Room", "Drawing Room", "Corridor"
        };

        public static string genName() {
            return names[MathUtils.RandomIntFromRange(0, names.Count-1)];
        }

        public static bool getRanBool() {
            return MathUtils.RandomIntFromRange(0, 1) == 0;
        }
    }
}


