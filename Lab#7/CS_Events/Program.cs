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
            MobileB mobile_ = new MobileB(10);
            mobile_.Notify += Display;
            bool alive = true;
            while (alive)
            {
                Console.WriteLine();
                Console.WriteLine("1.Активизация пакета // 2.Пополнить счёт на 10 // 3. Стан рахунку");
                Console.WriteLine("4.Купити 10 дзiнкiв за 10грн // 5. Вийти з програми ");
                Console.WriteLine();
                try
                {
                    int command = Convert.ToInt32(Console.ReadLine());
                    switch(command)
                    {
                        case 1:
                            mobile_.Activate();
                            break;
                        case 2:
                            mobile_.Put(10);
                            break;
                        case 3:
                            mobile_.ForNow();
                            break;
                        case 4:
                            mobile_.Zmensh(10);
                            break;
                        case 5:
                            alive = false;
                            continue;
                    }
                }
                catch
                {
                    throw new Exception();
                }
            }

            Console.ReadKey();
        }
        private static void Display(object sender, AccountEventArgs e)
        {
             Console.WriteLine(e.Message);
    
        }
    }
}
