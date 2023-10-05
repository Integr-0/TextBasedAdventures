// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class ElementGenerator {
        public static List<string> names = new List<string>() {
            "Barrel", "Chest", "Box", "Trashcan", "Rack", "Large Chest", "Cabinet"
        };
        
        public static ElementList getElementList() {
            int maxItemCount = MathUtils.RandomIntFromRange(0, 3);
            ElementList returnList = new ElementList();
            for (int I = 0; I <= maxItemCount; I++) {
                returnList.add(new Element(names[MathUtils.RandomIntFromRange(0, names.Count-1)], LootGenerator.getItemList()));
            }
            return returnList;
        }
    }
}


