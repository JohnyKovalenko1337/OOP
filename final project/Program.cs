using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{


    public class AccountEventArgs
    {
        // property Message
        public string Message { get; set; }

        public AccountEventArgs(string mes)
        {
            Message = mes;

        }
    }

    public delegate void AcHand(object sender, AccountEventArgs e); //delegate


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kovalenko Yevhen IS-93 ");

            Workers worker1 = new Workers("Tom", 24);       //making 3 workers for our program
            Workers worker2 = new Workers("John", 25);
            Workers worker3 = new Workers("Luca", 34);
    

            List<Workers> workers = new List<Workers>() { worker1, worker2, worker3 }; // list of workers

            worker1.Notify += Display;      // adding an event for a worker1
            worker2.Notify += Display;      // adding an event for a worker2
            worker3.Notify += Display;      // adding an event for a worker3

            Tasks tasky = new Tasks("asd","asdf",1,2);//making test tasky 

            Console.WriteLine("Input first Task");          //inputing of first task
            Console.WriteLine();

            Console.WriteLine("Input name of task:");
            string name = Console.ReadLine();               // inputing name

            Console.WriteLine("Input description of the task: ");
            string description = Console.ReadLine();            //inputing description

            Console.WriteLine("Input time:");
            int time = Convert.ToInt32(Console.ReadLine());         // inputing time

            Console.WriteLine("Input priority of task, where 1 is the most important task: ");
            int priority = Convert.ToInt32(Console.ReadLine());             //inputing priority

            Tasks task1 = new Tasks(name, description, time, priority);     //initialise the new task

            List<Tasks> NotStarted = new List<Tasks>();     //list of not started tasks
            List<Tasks> pending = new List<Tasks>();        // list of pending tasks
            List<Tasks> doned = new List<Tasks>();          // list of doned tasks

            NotStarted.Add(task1);      // adding first task to Not started list
       

            int q ;
            bool alive = true;

            while (alive)
            {
                Console.WriteLine();
                Console.WriteLine("         1.Add task      |  2.Tasks menu");
                Console.WriteLine("         3.Free workers  |  4.Exit Program");
                Console.WriteLine();
                try
                {
                    int command = Convert.ToInt32(Console.ReadLine());
                    switch(command)
                    {

                        case 1:
                            // ------ Inputing task -----------
                            Console.WriteLine("Input name of task:");
                             name = Console.ReadLine();
                            Console.WriteLine("Input description of the task: ");
                             description = Console.ReadLine();
                            Console.WriteLine("Input time:");
                             time = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Input priority of task, where 1 is the most important task: ");
                             priority = Convert.ToInt32(Console.ReadLine());

                                //adding task to not started list 
                             NotStarted.Add(new Tasks(name, description, time, priority));
                             Console.WriteLine("Task has been successfuly added");
                             break;

                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("|=============================================|");
                            Console.WriteLine("|                Tasks menu                   |");
                            Console.WriteLine("|=============================================|");
                            Console.WriteLine("|                                             |");
                            Console.WriteLine("|             Not Started Tasks:              |");
                            Console.WriteLine("|                                             |");
                            Print_List_Start(NotStarted);
                            Console.WriteLine("|                                             |");
                            Console.WriteLine("|=============================================|");
                            Console.WriteLine("|                                             |");
                            Console.WriteLine("|             On pending Tasks:               |");
                            Console.WriteLine("|                                             |");
                            Print_List_End(pending);
                            Console.WriteLine("|                                             |");
                            Console.WriteLine("|=============================================|");
                            Console.WriteLine("|                                             |");
                            Console.WriteLine("|               Done Tasks:                   |");
                            Console.WriteLine("|                                             |");
                            Print_List_End(doned);
                            Console.WriteLine("|=============================================|");
                            Console.WriteLine("|                                             |");
                            Console.WriteLine("|  1. Take the highest priority task          |"); 
                            Console.WriteLine("| 2.End the fastest task from on pending      |");
                            Console.WriteLine("| 6. Back                                     |");
                            Console.WriteLine("|=============================================|");
                            Console.WriteLine();
                            int command1 = Convert.ToInt32(Console.ReadLine());
                            switch (command1)
                            {
                                case 1:
                                    if (NotStarted.Count() != 0) 
                                    { 
                                         Console.WriteLine();
                                         Console.WriteLine("Choose a worker: ");
                                     
                                            q = 0;
                                        foreach(Workers i in workers)
                                        {
                                            if (!i.activity) {
                                                q++;
                                                Console.WriteLine(q.ToString() + " " + i.returnName());
                                           
                                            }
                                         
                                        }

                                            Console.WriteLine();
                                            Console.WriteLine("|=================================================|");
                                            Console.WriteLine("|    1.Choose "+worker1.returnName()+"  || 2.Choose "+ worker2.returnName()+"               |");
                                            Console.WriteLine("|    3.Choose "+worker3.returnName()+" || 4.Back                      |");
                                            Console.WriteLine("|=================================================|");
                                            Console.WriteLine();
                                            int command12 = Convert.ToInt32(Console.ReadLine());
                                            switch (command12)
                                            {
                                                case 1:
                                                    if (!worker1.activity)
                                                    {

                                                        tasky = NotStarted[0];      // take first elem of list notstarted

                                                        NotStarted.RemoveRange(0, 1);   //remove tasky from notstarted list
                                                        pending.Add(tasky);         //adding tasky to list pending
                                                        worker1.Take_Task(tasky);   //event to take task for worker
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("This worker is busy choose another one");
                                                    }
                                                    break;
                                                case 2:
                                                    if (!worker2.activity)
                                                    {
                                                        tasky = NotStarted[0];      // take first elem of list notstarted
                                                        NotStarted.RemoveRange(0,1);   //remove tasky from notstarted list
                                                        pending.Add(tasky);         //adding tasky to list pending
                                                        worker2.Take_Task(tasky);   //event to take task for worker
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("This worker is busy choose another one");
                                                    }
                                                    break;
                                                case 3:
                                                    if (!worker3.activity)
                                                    {
                                                        tasky = NotStarted[0];          // take first elem of list notstarted
                                                        NotStarted.RemoveRange(0, 1);     //remove tasky from notstarted list
                                                        pending.Add(tasky);        //adding tasky to list pending
                                                        worker3.Take_Task(tasky); //event to take task for worker
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("This worker is busy choose another one");
                                                    }
                                                    break;
                                                case 4:
                                                  //end
                                                    break;
                                            }
                                            break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("We have 0 Not started tasks!");
                                        break;
                                    }
                                case 2:
                                        tasky = pending[0];
                                        pending.Remove(tasky);              // remove task from pending list
                                        doned.Add(tasky);               //add task to list doned
                                        tasky.worker.End_task(tasky);       // event End task
                                        break;
                                case 6:
                                        break;
                            }
                             break;
                        case 3:
                            // output free workers
                            q = 0;
                            Console.WriteLine();
                            Console.WriteLine("Free workers: ");
                            foreach(Workers i in workers)
                            {
                                if (!i.activity)
                                {
                                    q++;
                                    Console.WriteLine(q.ToString() + " " + i.returnName()); 
                                    
                                }
                                
                            }
                           
                             break;
                        case 4:
                            alive = false;
                            continue;
                    }
                }
                catch
                {
                    throw new Exception();      // catching any exceptions
                }
            }

            Console.ReadKey();
        }
        // ================================  func to display event=======================
        private static void Display(object sender, AccountEventArgs e) 
        {
             Console.WriteLine(e.Message);
    
        }
        // ================================ output list of notstarted =======================
        private static void Print_List_Start(List<Tasks> tasks)
        {
            tasks.Sort(CompareTasksPriority); //sorting list by priority
            foreach(Tasks i in tasks){
                
                Console.WriteLine("| "+i.Return_name()+"   Time: " + i.Return_time().ToString() + "   Priority: "+ i.Return_priority().ToString());
            }
            
        }
        // ================================ output list of pending and doned=======================
        private static void Print_List_End(List<Tasks> tasks) 
        {
            tasks.Sort(CompareTasksTime);//sorting list by time
            foreach (Tasks i in tasks)
            {

                Console.WriteLine("| "+i.Return_name() + " Time: " + i.Return_time().ToString() + " Priority: " + i.Return_priority().ToString()+ " Worker: " + i.worker.returnName());
            }

        }
        //=======================func to compare priorities of task=========================
        public static int CompareTasksPriority(Tasks task1, Tasks task2) 
        {
            return task1.Return_priority().CompareTo(task2.Return_priority());
        }
        //=======================func to compate time of tasks=======================
        public static int CompareTasksTime(Tasks task1, Tasks task2)
        {
            return task1.Return_time().CompareTo(task2.Return_time());
        }
        //=====================================================================================
    }
}
