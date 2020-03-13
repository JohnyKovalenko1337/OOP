using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Vidnimanya(ref int a)
        {
            int Ai;
	        for (int mask = 0; mask < sizeof(int) * 8 - 1; mask++) //перебираємо 8 масок
	        {
		        if ((a & (1 << mask))==1)  
                { Ai = 1; }		//якщо а = здвигу 1 на маску то а1 = 1
		        else Ai = 0;
		        if (Ai == 1)
		        {
			        for (int i = 0; i < mask + 1; i++)
			        {
				        a = a ^ (1 << i);			// якщо біти а != 1 << i 
			        }
			        break;
		        }
	        }
        }
        public static bool Vidnoshenya(int A, int B)
        {
            int Num_1, Num_2;
            bool flag = false;
            for (int mask = sizeof(int) * 8 - 1; mask >= 0; mask--)
            {
                Num_1 = A & (1 << mask);        
                Num_2 = B & (1 << mask);
                if (Num_1 > Num_2)      //перевірка 
                {
                    flag = true;
                    break;
                }
                else
                    if (Num_1 < Num_2) //перевірка
                    {
                        flag = false;
                        break;
                    }
            }
            return flag;
         }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Kovalenko Yevhen IS-93");
            Console.WriteLine("Vvedit chislo dlya zmenshenya na 1");
            a = Convert.ToInt32(Console.ReadLine());
            Vidnimanya(ref a);
            Console.WriteLine("Result: ");
            Console.WriteLine(a);
            Console.WriteLine("Vvedit chisla dlya porivnyanya na znak bilshe:");
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            bool d = Vidnoshenya(b, c);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
