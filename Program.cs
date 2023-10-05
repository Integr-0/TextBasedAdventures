// Reitbauer Erik 1BHIF
// Übung: Game
// Eigene Utility Classes Eingefügt
// Each Round consists of 1. Player Movement 2. Player Action

namespace project {
    class Program {
        public static int playerY = 0;
        public static int playerX = 0;
        public static int playerHealth = 20;
        public static RoomManager roomManager = new RoomManager();
        public static Room? current = roomManager.Get(0, 0);
        public static Inventory inventory = new Inventory();

        public static void Main() {
            Game.start();
        }   
    }
}


