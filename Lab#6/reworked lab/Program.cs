using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Rhombus
    {

        private Point A;
        private Point B;
        private Point C;
        private Point D;

        private struct Point
        {
            public double x;
            public double y;
        };
        //Конструктор №1
        public Rhombus()
        {
            A.x = 0;
            A.y = 0;

            B.x = 2;
            B.y = 2;

            C.x = 4;
            C.y = 0;

            D.x = -2;
            D.y = -2;
        }
        //Конструктор №2
        public Rhombus(double a1, double a2, double b1, double b2, double c1, double c2, double d1, double d2)
        {
            A.x = a1;
            A.y = a2;

            B.x = b1;
            B.y = b2;

            C.x = c1;
            C.y = c2;

            D.x = d1;
            D.y = d2;
        }
        //Конструктор №3
        public Rhombus(Rhombus other)
        {
            A.x = other.A.x;
            A.y = other.A.y;

            B.x = other.B.x;
            B.y = other.B.y;

            C.x = other.C.x;
            C.y = other.C.y;

            D.x = other.D.x;
            D.y = other.D.y;
        }
        //властивість знаходження площі
        public double Square
        {
            get
            {
                double d1 = Math.Sqrt(Math.Pow(A.x - C.x, 2) + Math.Pow(A.y - C.y, 2));
                double d2 = Math.Sqrt(Math.Pow(B.x - D.x, 2) + Math.Pow(B.y - D.y, 2));

                return d1 * d2 / 2;
            }
        }
        //властивість знаходження периметра
        public double Perimetr
        {
            get
            {
                double result = 4 * Math.Sqrt((D.x - A.x) * (D.x - A.x) + (D.y - A.y) * (D.y - A.y));
                return result;
            }
        }

       //метод множення координат ромба на число
        private static Rhombus Multiply(Rhombus rhomb, double number)
        {
            if (number < 0)
            {
                throw new Exception("Ne mojna mnojiti na menshe nulya");
            }
            else{
            Rhombus result = new Rhombus(rhomb);

            result.A.x = result.A.x * Math.Sqrt(number);
            result.A.y = result.A.y * Math.Sqrt(number);

            result.B.x = result.B.x * Math.Sqrt(number);
            result.B.y = result.B.y * Math.Sqrt(number);

            result.C.x = result.C.x * Math.Sqrt(number);
            result.C.y = result.C.y * Math.Sqrt(number);

            result.C.x = result.C.x * Math.Sqrt(number);
            result.C.y = result.C.y * Math.Sqrt(number);

            return result;
            }
        }
        //перезавантаження оператору множення
        public static Rhombus operator *(Rhombus rhomb, double number)
        {
            Rhombus temp = Rhombus.Multiply(rhomb, number);
            return temp;
        }
        //перезавантаження оператору віднімання для віднімання площ
        public static Rhombus operator -(Rhombus first, Rhombus second)
        {
            if (first.Square == 0)
            {
                throw new DivideByZeroException("square = 0");
            }
            else
            {
                Rhombus temp = new Rhombus();
                double subtraction = first.Square - second.Square;
                temp = first * (subtraction / first.Square);

                return temp;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rhombus P1 = new Rhombus();
            Rhombus P2 = new Rhombus(2, 0, 4, 2, 6, 0, 4, -2);
            Rhombus P3 = new Rhombus( P2 * 2);

            Console.WriteLine("Kovalenko Yevhen Is-93 Variant #10");

            Console.WriteLine("Perimetr of P1 rhombus: " + P1.Perimetr.ToString("0.00"));
            Console.WriteLine("Perimetr of P2 rhombus: " +P2.Perimetr.ToString("0.00"));
            Console.WriteLine("Perimetr of P3 rhombus: " + P3.Perimetr.ToString("0.00"));

            Console.WriteLine("Square of P1 rhombus: " + P1.Square.ToString("0.00"));
            Console.WriteLine("Square of P2 rhombus: " + P2.Square.ToString("0.00"));
            Console.WriteLine("Square of P3 rhombus: " + P3.Square.ToString("0.00"));

            P1 = P3 - P2;

            Console.WriteLine("Square of P1 rhombus: " + P1.Square.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
