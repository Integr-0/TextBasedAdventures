// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class ItemList {
        public List<Item> items = new List<Item>();
        
        public ItemList add(Item e) {
            items.Add(e);
            return this;
        }

        public void clear() {
            items.Clear();
        }
    }
}


