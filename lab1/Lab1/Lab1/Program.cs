using System;

namespace Lab1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string inputData = "";
            while (!inputData.Equals("close"))
            {
                Console.Write("Enter program name: ");
                
                string name = Console.ReadLine();
                Console.Write("Enter numPeople: ");
                
                int numPeople = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter num tasks in history: ");
                
                int numHistory = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter tasks in history: ");
                
                string[] history = new string[numHistory];
                for (int i = 0; i < numHistory; i++)
                {
                    history[i] = Console.ReadLine();
                }
                Console.Write("Enter current tasks num: ");
                int currentTaskNum = Convert.ToInt32(Console.ReadLine());
                
                Task[] tasks = new Task[currentTaskNum];
                for (int i = 0; i < currentTaskNum; i++)
                {
                    Console.Write("Enter task name: ");
                    string taskname = Console.ReadLine();
                    Console.Write("Enter task complexity: ");
                    int complexity = Convert.ToInt32(Console.ReadLine());
                    Task.Complexity taskComplexity = Task.Complexity.EASY;
                    switch (complexity)
                    {
                        case 0:
                            taskComplexity = Task.Complexity.EASY;
                            break;
                        case 1:
                            taskComplexity = Task.Complexity.MEDIUM;
                            break;
                        case 2:
                            taskComplexity = Task.Complexity.HARD;
                            break;
                        case 3:
                            taskComplexity = Task.Complexity.VERY_HARD;
                            break;
                    }

                    tasks[i] = new Task(taskname, taskComplexity);

                }

                TaskManager taskManager = new TaskManager(name, tasks, numPeople, history);
                Console.WriteLine("Time for all tasks: "+taskManager.countTasksTime()+" hours");
                Console.WriteLine("Task history: ");
                taskManager.printTaskHistory();
                Console.WriteLine("Print 'close' if your want close: ");
                inputData = Console.ReadLine();



            }


        }
    }

    class TaskManager
    {
        public string programName;
        public int numPeople;
        public string[] taskHistory;

        public Task[] tasks;


        public TaskManager(string _programName, Task[] _tasks, int _numPeople, string[] _taskHistory)
        {
            programName = _programName;
            numPeople = _numPeople;
            taskHistory = _taskHistory;
            tasks = _tasks;

        }

        public double countTasksTime()
        {
            double time = 0;
            if (tasks == null)
            {
                return 0;
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                int taskTime = tasks[i].getTaskTime();
                time += (double) taskTime / (double) numPeople;
            }

            return time;
        }

        public void cleanTasks()
        {
            tasks = null;
        }

        public void cleanTasksHistory()
        {
            taskHistory = null;

        }

        public void printTaskHistory()
        {
            for (int i = 0; i < taskHistory.Length; i++)
            {
                Console.WriteLine(taskHistory[i]+" ");
            }
        }
    }

    class Task
    {
        public enum Complexity
        {
            EASY,
            MEDIUM,
            HARD,
            VERY_HARD
            
        }
        private string name;
        private Complexity complexity;

        public Task(string _name, Complexity _complexity)
        {
            name = _name;
            complexity = _complexity;
        }

        public int getTaskTime()
        {
            switch (complexity)
            {
                case Complexity.EASY:
                    return 1;
                    break;
                case Complexity.MEDIUM:
                    return 2;
                    break;
                case Complexity.HARD:
                    return 3;
                    break;
                case Complexity.VERY_HARD:
                    return 4;
                    break;
            }

            return 0;
        }
        

    }
}