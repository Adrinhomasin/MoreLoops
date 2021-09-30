using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correctnum = random.Next(1, 11);
            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("vali number 1-10");
                int usernum = Convert.ToInt32(Console.ReadLine());

                if (correctnum == usernum)
                {
                    Console.WriteLine("palju õnne");
                    break; //i = 3
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"proovi uuest {3 - i} katset jäänd noob");
                }
                
            }
            

            
        }
    }
}
