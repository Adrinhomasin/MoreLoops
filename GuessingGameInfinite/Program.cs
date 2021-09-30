using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correctnum = random.Next(1, 11);
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("vali number 1-10");
                int num = Convert.ToInt32(Console.ReadLine());

                if (correctnum == num)
                {
                    Console.WriteLine("palju õnne põder");
                    loop = false;

                }
                else
                {
                    Console.WriteLine("vale vastus");
                }
            }
        }
    }
}
