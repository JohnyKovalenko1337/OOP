using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    interface IWorkers                  // interface for class Workers
    {
        private string name;
        private int age;
        public bool activity;
        public void Take_Task(Tasks task);      // every worker should to take task
        public void End_task(Tasks task);       // every worker should to end task
    }
    class Workers:IWorkers
    {
        public event AcHand Notify;         // event Notify based on delegate AcHand with parameters (object sender, AccountEventArgs e)

        private string name;
        private int age;
        public bool activity = false;


        public Workers(string name, int age)        // constructor
        {
            if (name == null)
            {
                throw new ArgumentNullException("Input name");
            }
            else
            {
                this.name = name;
            }


            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("Age cant be smaller than 0");
            }
            else
            {
                this.age = age;
            }

        }

        public string returnName()
        {
           return this.name;
           
        }

        public void Take_Task(Tasks task)
        {
            activity = true;        // if we take task worker is active
            task.worker = this;     // set tasks worker by a property of task
            if (Notify != null)
            {                       // calling an event
                Notify(this, new AccountEventArgs("Task " + task.Return_name() + " are making by worker " + this.name));
            }
        }

        public void End_task(Tasks task)
        {
            
            activity = false;           // when we end task worker is not active

            if (Notify != null)
            {           // calling an event
                Notify(this, new AccountEventArgs("Task " + task.Return_name() + " has been done by worker " + this.name));// Вызов события
            }
        }
    }
}
