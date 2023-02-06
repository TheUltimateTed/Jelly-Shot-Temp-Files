namespace Namespace {
    
    public static class Module {
        
        public static object startDirection = 0;
        
        public static object posX = 0;
        
        public static object posY = 0;
        
        public static object invItems = 0;
        
        public static object health = 10;
        
        public static object Coins = 100;
        
        public static object gameover = 0;
        
        public static object looseHealth(object amount) {
            health = health - amount;
            if (health < 1) {
                var gameover = 1;
            }
        }
        
        public static object addBullets(object am2) {
            Coins = Coins - am2;
            if (Coins < 1) {
                var gameover = 1;
            }
        }
        
        public static object gameover() {
            if (gameover == 1) {
                Console.WriteLine("Whoops Game Over");
            }
        }
        
        public static object username = input("What Do You Want Your Name To Be?");
    }
}
