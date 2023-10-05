// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class ElementList {
        public List<Element> elements = new List<Element>();
        
        public ElementList add(Element e) {
            elements.Add(e);
            return this;
        }
    }
}


