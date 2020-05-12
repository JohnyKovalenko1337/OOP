using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs1
{
    delegate string _Str(string[] str);                             //delegate

    class Delegater
    {


        public static string GetString_1(string[] str){             // static method
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result = result + str[i][i];
            }
                return result;
        }
        public string GetString_2(string[] str)                     // usual method
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result = result + str[i][i];
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kovalenko Yevhen IS-93 Variant#10");
            Console.WriteLine("Input number of strings: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[n];
            Console.WriteLine("Now input your strings:");
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            _Str del;
            del = Delegater.GetString_1;                // delegate for static method
            Console.WriteLine(del(str));

            Delegater qq = new Delegater();

            del = qq.GetString_2;                       // delegate for usual method

            Console.WriteLine(del(str));
            Console.ReadKey();
        }
    }
}
