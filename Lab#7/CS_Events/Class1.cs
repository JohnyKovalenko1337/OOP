using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    class AccountEventArgs
    {
        // Сообщение
        public string Message { get; set; }

        public AccountEventArgs(string mes)
        {
            Message = mes;

        }
    }
    class MobileB
    {
        public delegate void AcHand(object sender, AccountEventArgs e);
        public event AcHand Notify;

        private int Sum;

        public MobileB(int sum)
        {
            Sum = sum;
        }
        public void Put(int sum)
        {
            Sum += sum;
            if (Notify != null)
            {
                Notify(this, new AccountEventArgs("На счет поступило " + sum.ToString()));// Вызов события
            }
        }
        public void Activate()
        {
            if (Notify != null)
            {
                Notify(this, new AccountEventArgs("Ваш тариф активирован"));// Вызов события
            }
        }
        public void ForNow()
        {
            if (Notify != null)
            {
                Notify(this, new AccountEventArgs("На счетy " + Sum.ToString()));// Вызов события
            }
        }
        public void Zmensh(int q)
        {
            Sum = Sum - q;
            if (Sum <= 0)
            {
                if (Notify != null)
                {
                    Notify(this, new AccountEventArgs("У вас недостатньо на рахунку"));
                }
            }
            else
            {
                if (Notify != null)
                {
                    Notify(this, new AccountEventArgs("Вам додано 10 дзвiнкiв"));
                }
            }
        }
    }
}
