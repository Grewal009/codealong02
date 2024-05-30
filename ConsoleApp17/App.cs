namespace ConsoleApp17;

public class App
{

    public static void Run()
    {
        Tasks task1 = new Tasks("buy grocery","monday");
        Tasks task2 = new Tasks("clean house","tuesday");
        Tasks task3 = new Tasks("make food","wednesday");

        List<Tasks> tasks = new List<Tasks>();
        tasks.Add(task1);
        tasks.Add(task2);
        tasks.Add(task3);
        
        while (true)
        {
            Menu();
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    ShowAllTasks();
                    break;
                case 2:
                    AddNewTask();
                    break;
                case 3:
                    GetDayTask();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("wrong input!!! try again!");
                    break;
            }
        }
        
        void AddNewTask()
        {
            Console.WriteLine($"enter new task:-----");
            Console.Write($"task: ");
            string task = Console.ReadLine();
            Console.Write("enter day: ");
            string day = Console.ReadLine();
            tasks.Add(new Tasks(task,day));

        }

        void GetDayTask()
        {
            bool isAvailable = false;
            Console.Write("Enter todays day: ");
            string input = Console.ReadLine();
            foreach (var task in tasks)
            {
                if (task.Day1 == input)
                {
                    Console.WriteLine($"task for {task.Day1} -> {task.Oppgave1}");
                    isAvailable = true;
                }
            }

            if (!isAvailable)
            {
                Console.WriteLine($"wrong input: {input}");
            }

        }

        void Menu()
        {
            Console.WriteLine("*** MENU ***");
            Console.WriteLine($"press 1 to show all tasks\npress 2 to add new task\npress 3 to get task for day\npress 5 to exit");
        }

        void ShowAllTasks()
        {
            Console.WriteLine("Tasks:------------");
            foreach (var task in tasks)
            {
                Console.WriteLine($"task: {task.Oppgave1} -> day: {task.Day1}");
            }
        }
        
    }
}