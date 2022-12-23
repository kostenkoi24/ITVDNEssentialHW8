using System;

namespace Homework8_2
{

    static class MyClass
    {
        public static void Print(string stroka, int color)
        {

            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine($"{stroka}");
            Console.ResetColor();
        }
    }

    enum Colors
    {
        DarkRed = 4,
        //
        // Summary:
        //     The color dark magenta (dark purplish-red).
        DarkMagenta = 5,
        //
        // Summary:
        //     The color dark yellow (ochre).
        DarkYellow = 6,
        //
        // Summary:
        //     The color gray.
        Gray = 7,
        //
        // Summary:
        //     The color dark gray.
        DarkGray = 8,

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            /*
             Використовуючи Visual Studio, створіть проект за шаблоном 
            Console Application. Створіть статичний клас із методом void Print (string stroka, int color), 
            який виводить на екран рядок заданим кольором. Використовуючи перелік, 
            створіть набір кольорів, доступних користувачеві. 
            Введення рядка та вибір кольору надайте користувачеві.
             */
            int result = -1;
            do
            {

                PrintColors();
                int.TryParse(Console.ReadLine(), out result);

                if (result == -1)
                {
                    break;
                }

                string stroka = Enum.GetName(typeof(Colors), result);

                MyClass.Print(stroka, result);
            } while (result != -1);


            

            
        }

        static void PrintColors()
        {
            Console.WriteLine("Введіть номер кольору:");
            Array array = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}, значення {0:D}", array.GetValue(i));
            }
            Console.WriteLine("Type '-1' for exit");
        }

    }
}
