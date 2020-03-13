using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MyText;

namespace main
{
    class Program
    {
        static void Main()
        {
            int strToDel, chars = 0;
            int amountOfStrs = 0;

            MyText.Mytext text = new MyText.Mytext();
            string inputing;

            Console.Write("Enter amount of strings: ");
            amountOfStrs = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < amountOfStrs; i++)
            {
                Console.Write("Entered {i + 1} string: ");
                inputing = Console.ReadLine();

                MyText.Mytext array = new MyText.Mytext();
                //перебираємо строки
                for (int j = 0; j < array.TheLength(inputing.Length); j++)
                {
                    array[j] = inputing[j];
                }
                text.AddStr(array);
                inputing.Remove(0);
            }

            Console.Write("\nEnter strings :");
            text.Print();

            Console.Write("\n---------------------------\n");

            Console.Write("\nEnter number of string to delete: ");
            strToDel = int.Parse(Console.ReadLine());
            text.DeleteStr(strToDel);

            Console.WriteLine("After deleteting string: ");
            text.Print();

            Console.WriteLine("\n---------------------------");

            Console.WriteLine("After cleaning: ");
            text.CleatText();
            text.Print();

            Console.ReadKey();
        }
    }
}
