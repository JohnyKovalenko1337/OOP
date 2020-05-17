using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kovalenko Yevhen IS-93 Variant#10");
            var node = new list();
            long b;
            long suma = 0;
            int counter = 0;
            int av = 0;
            bool alive = true;
            while (alive)
            {
                Console.WriteLine();
                Console.WriteLine("1.Додати елемент в кiнець списку         // 2.Кiлькiсть кратних 5 на парних позицiях");
                Console.WriteLine("3.Видалити елементи якi бiльше середнього // 4. Вийти з програми ");
                Console.WriteLine();
               
                    int command = Convert.ToInt32(Console.ReadLine());
                    switch (command)
                    {
                        case 1:
                            
                            Console.Write("Input element = ");
                            b = long.Parse(Console.ReadLine());
                            suma = suma +b;
                            counter++;
                            node.push_Back(b);
                            
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Answer: ",node.CountMultiples().ToString());
                            break;
                        case 3:
                            av = Convert.ToInt32(suma/counter);
                            node.Remove(av);
                            break;
                        case 4:
                            alive = false;
                            continue;
                     
                            
                    }
           }
        }
    }
}
