// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class LootGenerator {
        public static List<Item> items = new List<Item>() {
            new Item("Sword"), 
            new Item("Shield"), 
            new Item("Fish"), 
            new Item("Chestplate"), 
            new Item("Steak"), 
            new Item("Apple"), 
            new Item("Bandage"), 
            new Item("Dagger"), 
            new Item("Bow"), 
            new Item("Potion of Healing"), 
            new Item("Fire Wand"), 
            new Item("Ice Wand"), 
            new Item("Dynamite"), 
            new Item("Long Sword"),
            new Item("Long <Long> Value") 
        };
        
        public static ItemList getItemList() {
            int maxItemCount = MathUtils.RandomIntFromRange(0, 3);
            ItemList returnList = new ItemList();
            for (int I = 0; I <= maxItemCount; I++) {
                returnList.add(items[MathUtils.RandomIntFromRange(0, items.Count-1)]);
            }
            return returnList;
        }
    }
}


