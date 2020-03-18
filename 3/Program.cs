using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Symbols
    {
        private List<char[]> massive; //двомірний масив символів
        private int prigolosni = 0; // кількість приголосних в масиві

        //конструктор для запису символів
        public Symbols(string[] strings)
        {
            massive = new List<char[]>(strings.Length);
            for(int i = 0; i < strings.Length; i++)
            {
                massive.Add(strings[i].ToCharArray());
            }
        }
        //індексатор , що складається з усіх
        //елементів заданого індексом рядка масиву
    //======================================================================
        public string this[int index]
        {
            get
            {
                string ryadok = new string(massive[index]);
                return ryadok;
            }
            set
            {
                massive[index] = value.ToCharArray();
            }
        }
    //=============================================================
        //властивість для підрахунку 
        //кількості приголосних літер у масиві
        public int Prigolos
        {
            get
            {
                char[] letters ={'q','w','r','t','p','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'};
                //перебір рядків в масиві
                foreach (char[] ryad in massive)
                {
                    // перебір символів в рядку
                    foreach (char symb in ryad)
                    {
                        // перебір голосних літер
                        foreach (char lett in letters)
                        {
                            if (symb == lett)
                            {
                                prigolosni++;
                            }
                        }
                    }
                }
                return prigolosni;
            }
            set
            {
                prigolosni = value; 
            }
        }
    }
    //=====================================================================
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            Console.WriteLine("Введiть рядки через пробiл: ");
            string[] words = Console.ReadLine().Split();

            Symbols symb = new Symbols(words);

            Console.Write("Введiть число рядка, якого ви хочете побачити:");
            index = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваш " + index + " рядок е: " + symb[index-1] );

            int kilkist = symb.Prigolos;

            Console.WriteLine("Кiлькiсть приголосних: " + kilkist);

            Console.ReadKey();

        }
    }
    
}
