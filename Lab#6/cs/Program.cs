using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exp;
namespace Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kovalenko Yevhen Is-93 Variant-10");
            Except[] objs =
            {
                //new Except(1, 0, 3, 4),    // divide by zero exeption
                //new Except(1,20, 30, 4),   // ariphmetic exeption
               new Except(0,2,28,4)           // no exeptions
            };
            foreach(var obj in objs ){
               Console.WriteLine( obj.calc());
            }
            Console.ReadKey();
        }
    }
}
