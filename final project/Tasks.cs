using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    interface ITasks                    // interface for class Tasks
    {
        private string name;            
        private string value;
        private int time, priority;
        public Workers worker;          //every task should have a worker

    }
    class Tasks: ITasks
    {
        private string name;
        private string value;
        private int time, priority;
        public Workers worker = null;
        
        public Tasks(string name, string value, int time, int priority)
        { //constructor

            if (name == null)
            {
                throw new ArgumentNullException("Input name");
            }
            else
            {
                this.name = name;
            }

            if (value == null)
            {
                throw new ArgumentNullException("Input task");
            }
            else
            {
                this.value = value;
            }
            if (time < 0)
            {
                throw new ArgumentOutOfRangeException("Time cant be smaller than 0");
            }
            else
            {
                this.time = time;
            }
            if (priority < 0)
            {
                throw new ArgumentOutOfRangeException("Priority cant be smaller than 0");
            }
            else
            {
                this.priority = priority;
            }

        }

        public int Return_time()            // returning time of task
        {
            return this.time;
        }
        public int Return_priority()        //returning priority of task
        {
            return this.priority;
        }
        public string Return_name()         // returning name of task
        {
            return this.name;
        }
    }
}
