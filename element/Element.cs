// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class Element {
        public string name;
        public ItemList items;
        
        public Element(string name, ItemList items) {
            this.name = name;
            this.items = items;
        }

        public void take() {
            Program.inventory.addAll(items);
            items.clear();
        }
    }
}


