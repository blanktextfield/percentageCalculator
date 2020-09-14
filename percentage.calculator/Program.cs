using System;

namespace percentage.calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            int UserScore;
            double Result;

            Console.WriteLine("What`s the maximum score?");
            max = int.Parse(Console.ReadLine());
            Console.WriteLine("What`s your score");
            UserScore = Int32.Parse(Console.ReadLine());
            Result = (UserScore * 100) / max;

            Console.WriteLine($"You scored {Result}%.");

            /*>90% - 5
             * >80% -4
             * >61% - 3
             * -2
             */

            if (Result >= 90)

            {
                Console.WriteLine("Sinu hinne on 5");

            } else if (Result >= 80)
            {
                Console.WriteLine("su hinne on 4");

            } else if (Result >= 61)
            {
                Console.WriteLine("su hinne on 3");


            }
            else if (Result <= 60) 

            {
                Console.WriteLine("su hinne on 2");

            }




        }
    }
}
