using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Capstone_TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a new Task object
            Task newTask = new Task("Keith", "Garbage Duty");
            Task secondTask = new Task("Jacob", "Dishes");


            //Print the different Objects
            Console.WriteLine(newTask.TaskOwner + " " 
                + newTask.TaskName + " " + newTask.DueDate);
            Console.WriteLine(secondTask.TaskOwner + " " 
                + secondTask.TaskName+ " " + newTask.DueDate);

            //create list
            List<Task> TaskList = new List<Task>();

            //We want to build a new list of tasks, so
            //  we're going to create a loop

            bool whileBool = false;
            string response = " ";

            //add as many tasks as you want with this
            while (whileBool)
            {
                TaskList.Add( new Task(Console.ReadLine(), Console.ReadLine());
                Console.WriteLine("quit");
                response = Console.ReadLine();

                if (response == "quit")
                    whileBool = false;
            }

            //pritn the tasks from the task List
            foreach (Task item in TaskList)
            {
                Console.WriteLine(item.TaskOwner + " " + item.TaskName);

            }
        }
    }
}
