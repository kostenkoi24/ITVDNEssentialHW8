using System;

namespace Homework8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть дату свого народження у форматі DD/MM/YYYY:");

            string userInput = Console.ReadLine();



            try
            {
                DateTime birthday = DateTime.Parse(userInput);

                string d = birthday.Day.ToString();
                string m = birthday.Month.ToString();
                string y = DateTime.Now.AddYears(1).Year.ToString();

                DateTime nextBirthday = DateTime.Parse(d + "/" + m + "/" + y);




                Console.WriteLine($"Yor bithday: {birthday.ToString("d")} \nNext birthday: {nextBirthday.ToString("d")} \nWait days: {(nextBirthday - DateTime.Now).Days}");

                

            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not in the correct format.", userInput);
            }


            Console.ReadKey();

        }
    }
}
