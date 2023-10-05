// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class Room {
        public string name;
        public int x;
        public int y;
        public bool doorUp;
        public bool doorDown;
        public bool doorLeft;
        public bool doorRight;
        public ElementList elements;
        public Room(string name, int x, int y, bool doorUp, bool doorDown, bool doorLeft, bool doorRight, ElementList elements) {
            this.name = name;
            this.x = x;
            this.y = y;
            this.doorUp = doorUp;
            this.doorDown = doorDown;
            this.doorLeft = doorLeft;
            this.doorRight = doorRight;
            this.elements = elements;
        }
    }
}


