namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PlayerRandomNumber , EnmyRandomNumber;

            int PlayerPoints = 0, EnmyPoints = 0 ;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press Any Key To Roll Dice .");

                Console.ReadKey();

                PlayerRandomNumber = random.Next(1, 7);
                Console.WriteLine($" You Rolled A : {PlayerRandomNumber}");

                Console.WriteLine("....");
                /*System.Threading.*/Thread.Sleep(1000);

                EnmyRandomNumber = random.Next(1, 7);
                Console.WriteLine($" Enmy AI Rolled A : {EnmyRandomNumber}");
                Console.WriteLine();

                if(PlayerRandomNumber > EnmyRandomNumber)
                {
                    PlayerPoints++;
                    Console.WriteLine(" Player Wins This Round !..");
                }
                else if(EnmyRandomNumber > PlayerRandomNumber)
                {
                    EnmyPoints++;
                    Console.WriteLine(" Enmy Wins This Round !..");
                }
                else
                    Console.WriteLine(" Draw!");

                Console.WriteLine($"The Score Is Now - Player : {PlayerPoints} ... - Enmy : {EnmyPoints}");
                Console.WriteLine();
            }

            if(PlayerPoints > EnmyPoints)
                Console.WriteLine(" You Win ^!^ ");
            else if(EnmyPoints > PlayerPoints)
                Console.WriteLine(" You Lose :( ");
            else
                Console.WriteLine(" It's Draw !");

            Console.ReadKey();
        }
    }
}
