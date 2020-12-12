namespace Day5_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var potato = new Products.BulkProduct("Potato", "Yellow", 15.4, 1.5, 5);
            potato.GetInfo();
            var computerGame = new Products.DigitProduct("Cyberpunk", "Digit Game", 500, 2000);
            computerGame.GetInfo();
            var rubiksCoube = new Products.PhysicalProduct("Rubik's coube", "Physical Game", 20, 100);
            rubiksCoube.GetInfo();
        }
    }
}
