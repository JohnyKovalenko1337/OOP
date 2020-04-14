using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    //=====================================Базовий клас====================================================
     class Ryadok
     {
         public virtual int Len() { return 0; } //віртуальна функція знаходження довжини
         public virtual void Sdvig() { }    //віртуальна функція здвигу останнього елемента на перше місце
     }
    //=================================Наслідуючий клас Цифри==================================================
     class Nums : Ryadok
     {
         private string nums;

         public Nums(int x1, int x2, int x3)                  //конструктор з параметрами
         {
             nums = x1.ToString()+" " + x2.ToString()+" " + x3.ToString();
         }

         public override int Len()  //знаходження довжини
         {
             return nums.Length;
         }
         public void Print()
         {
             Console.WriteLine("Numbers :" + nums);
         }
         public override void Sdvig()   // здвиг цифр
         {
             char temp;
             char[] array;
             
             array = nums.ToCharArray();
             int k = 1;
             for (int j = 0; j < k; j++)
             {
                 temp = array[array.Length - 1];
                 for (int i = array.Length-1; i >= 1; i--)
                     array[i] = array[i - 1];
                 array[0] = temp;
             }
             string nummy = new string(array);

             Console.WriteLine("Sdvig:");
             Console.WriteLine(nummy);
         }
     }
     //=========================================Клас наслідник Нижні букви===============================================
     class LowerLetters : Ryadok
     {
          private string lower;

         public LowerLetters(string s) //конструктор
         {
             lower = s;
         }

         public void Print()
         {
             Console.WriteLine("LowerLetters :" + lower);
         }

         public override int Len() //довжина
         {
             return lower.Length;
         }

         public override void Sdvig() // здвиг
         {
             char temp;
             char[] array;
             
             array = lower.ToCharArray();
             int k = 1;
             for (int j = 0; j < k; j++)
             {
                 temp = array[array.Length - 1];
                 for (int i = array.Length-1; i >= 1; i--)
                     array[i] = array[i - 1];
                 array[0] = temp;
             }
             string lowwy = new string(array);

             Console.WriteLine("Sdvig:");
             Console.WriteLine(lowwy);
         }
     }
    //=============================================================================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kovalenko Yevhen IS-93");

            Nums num = new Nums(1, 2, 45);

            num.Print();

            Console.WriteLine("Numbers Length:" + num.Len());

            num.Sdvig();

            LowerLetters low = new LowerLetters("asdasd");

            low.Print();


            Console.WriteLine("LowerLetters Length:" + low.Len());

            low.Sdvig();

            Console.ReadKey();
        }
    }
}
