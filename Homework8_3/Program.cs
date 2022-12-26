using System;

namespace Homework8_3
{

    enum Positions
    {
        Director = 2,
        Manager = 5,
        Buhgalter = 8,
        Security = 16
    }

    class Account
    {

        public static bool AskForBonus(Positions worker, int hours)
        {
            if (hours > (int)worker)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Positions p = Positions.Director;
            int hours = 6;

            Console.WriteLine("Position: {0}, Work hours: {1}, Norma: {2}, Bonus {3}", p, hours, ((int)p), Account.AskForBonus(p, hours));

            p = Positions.Security;
            hours = 15;
            Console.WriteLine("Position: {0}, Work hours: {1}, Norma: {2}, Bonus {3}", p, hours, ((int)p), Account.AskForBonus(p, hours));


            p = Positions.Buhgalter;
            hours = 9;
            Console.WriteLine("Position: {0}, Work hours: {1}, Norma: {2}, Bonus {3}", p, hours, ((int)p), Account.AskForBonus(p, hours));


            Console.ReadKey();
        }
    }
}
