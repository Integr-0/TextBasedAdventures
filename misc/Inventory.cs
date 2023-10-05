// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class Inventory {
        public List<Item> items = new List<Item>();
        
        public Inventory add(Item e) {
            items.Add(e);
            return this;
        }

        public void addAll(ItemList items) {
            foreach (Item item in items.items) {
                this.items.Add(item);
            }
        }

        public void printAll() {
            Logger.Empty();
            Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.DarkYellow);
            Logger.Empty();
            if (items.Count > 0) {
                foreach (Item item in items) {
                    Logger.DefaultMessage("You have "+item.name+"!",ConsoleColor.DarkYellow);
                }
            } else {
                Logger.DefaultMessage("Inventory is Empty!", ConsoleColor.DarkYellow);
            }
            Logger.Empty();

            Logger.DefaultMessage("-----------------------------------------------------------------------", ConsoleColor.DarkYellow);
        }
    }
}


