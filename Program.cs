namespace DiceGameCSL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AlphaRandomNum;
            int BetaRandomNum;

            int AlphaPoint = 0;
            int BetaPoint = 0;

            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey(true);

                AlphaRandomNum = random.Next(1, 7);
                Console.WriteLine("Alpha rolled a " + AlphaRandomNum);

                Console.WriteLine(".......");
                System.Threading.Thread.Sleep(2000);

                BetaRandomNum = random.Next(1, 7);
                Console.WriteLine("Beta rolled a " + BetaRandomNum);

                if ( AlphaRandomNum > BetaRandomNum)
                {
                    AlphaPoint++;
                    Console.WriteLine("Alpha wins this round!");

                }
                else if (AlphaRandomNum < BetaRandomNum)
                {
                    BetaPoint++;
                    Console.WriteLine(" Beta wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine($"The score is now Alpha : {AlphaPoint}  Beta: {BetaPoint}");
                Console.WriteLine();
            }
            if (AlphaPoint > BetaPoint)
                Console.WriteLine("Alpha wins");
            else if (AlphaPoint < BetaPoint)
            {
                Console.WriteLine("Beta wins!");
            }
            else { Console.WriteLine("Its a Draw!"); }
            Console.ReadKey();
        }
    }
}
