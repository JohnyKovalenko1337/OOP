using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exp
{
    class Except
    {
        private double a, b, c, d;
        public Except(double a1, double b1, double c1, double d1){     //конструктор з ексепшенами

            this.a = a1;

            if (b1 != 0)
            {
                this.b = b1;

                if (24 + d1 - c1 >= 0)
                {
                    this.c = c1;
                    this.d = d1;
                }
                else
                {
                    throw new ArithmeticException("Korin doljen buty bilshe abo rivne 0");
                }
            }
            else
            {
                throw new DivideByZeroException("Wrong number b");
            }
        }
        public double getA(){return a;}  // Get value of A

        public double getB(){return b;}  // Get value of B

        public double getC(){return c;}  // Get value of C

        public double getD(){return d;}  // Get value of D

        public double calc()
        {
            double res;
           if((Math.Sqrt(24 + d - c) + a / b)==0){
                 throw new DivideByZeroException("Nemojna dilit na 0");
                }
           else{
               return (1 + a - b / 2) / (Math.Sqrt(24 + d - c) + a / b);
            }
            
        }
    }
}
