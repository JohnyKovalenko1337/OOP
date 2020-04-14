using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    //=================================================Базовий клас==================================
    class Line
    {
        private struct Point  //точки
        {
            public double x;
            public double y;
        };
        private Point A, B,C;
        public Line(double a1,double b1,double a2,double b2){ //конструктор
            A.x = a1;
            A.y = b1;
            B.x = a2;
            B.y = b2;
            C.x = a2 - a1;
            C.y = b2 - b1;
        }
        public double LineLeng              //довжина лінії
        {
            get
            {
                double result = Math.Sqrt(Math.Pow((C.x), 2) + Math.Pow((C.y), 2));
                return result;
            }
        }
    }
    //=========================================================Клас Наслідник=====================================
    class Segment : Line
    {
        private struct Point //точки
        {
            public double x;
            public double y;
        };
        private Point A, B,C;
        public Segment(double a1, double b1, double a2, double b2)//конструктор
            : base(a1, b1, a2, b2)
        {
            A.x = a1;
            A.y = b1;
            B.x = a2;
            B.y = b2;
            C.x = a2 - a1;
            C.y = b2 - b1;
        }
        public void Print() //виведення
        {
            Console.Write(C.x);
            Console.Write(" ");
            Console.Write(C.y);
            Console.WriteLine();
        }
        public Segment Zmenshennya(double n) //зменшення відрізка
        {

            this.C.x = B.x - (B.x - A.x) / this.LineLeng * n;
            this.C.y = B.y - (B.y - A.y) / this.LineLeng * n;
            Console.WriteLine(Math.Sqrt(Math.Pow((C.x), 2) + Math.Pow((C.y), 2)));
            return this;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kovalenko Yevhen Is-93 Variant #10");

            Line l1 = new Line(1, 0, 1, 7);

            Console.WriteLine("Довжина лiнii");

            Console.WriteLine(l1.LineLeng);

            Segment seg1 = new Segment(0, 1, 10 , 1);

            Console.WriteLine("Довжина вiдрiзку");
            Console.WriteLine(seg1.LineLeng);
            Console.WriteLine("Координати вiдрiзку");
            seg1.Print();

            Console.WriteLine("Довжина вiдрiзку пiсля зменшення");
            seg1.Zmenshennya(5);

            Console.WriteLine();
            Console.WriteLine("Координати вiдрiзку пiсля зменшення");
            seg1.Print();

            
    

            Console.ReadKey();
        }
    }
}
