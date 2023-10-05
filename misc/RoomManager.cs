// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt

using System.Runtime.CompilerServices;

namespace project {
    class RoomManager {
        public List<Room> rooms = new List<Room>();

        public RoomManager() {
            addRooms();
        }

        public void addRooms() {
            rooms.Add(new Room("Spawn", 0, 0, false, false, false, true, new ElementList()
            .add(new Element("Chest", new ItemList()
                .add(new Item("Sword"))
                .add(new Item("Shield"))))));
            rooms.Add(new Room("Kitchen", 1, 0, false, false, true, false, new ElementList()
            .add(new Element("Barrel", new ItemList()
                .add(new Item("Fish"))))));
        }
        
         public Room? Get(string name) {
            foreach (Room room in rooms) {
                if (room.name == name) {
                    return room;
                }
            }
            return null;
        }

        public Room? Get(int x, int y) {
            foreach (Room room in rooms) {
                if (room.x == x && room.y == y) {
                    return room;
                }
            }
            return null;
        }

        public bool Exists(int x, int y) {
            foreach (Room room in rooms) {
                if (room.x == x && room.y == y) {
                    return true;;
                }
            }
            return false;
        }
    }
}


