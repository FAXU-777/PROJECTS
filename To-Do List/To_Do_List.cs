using System.Diagnostics.Metrics;
using first.NewDirectory1;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to To-Do List Manager");
        List<string> task = new List<string>();
        List<string> completedTasks = new List<string>();


        while (true)
        {


            Console.WriteLine("--Menu--");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Comleted Tasks");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();


            while (!int.TryParse(choice, out _))
            {
                Console.WriteLine("Please enter number");
                choice = Console.ReadLine();
                
            }


            switch (choice)
            {
                case "1" :
                    Console.WriteLine("Enter task you want to add");
                     string newtask = Console.ReadLine();
                    
                    while (int.TryParse(newtask, out _))
                    {
                        Console.WriteLine("Enter task not just number!");
                        newtask = Console.ReadLine();
                    }
                    
                    task.Add(newtask);

                    break;
                case "2" :
                    Console.WriteLine("Your tasks : ");
                   
                    ViewTasks(task, "Current tasks"  );
                    
                    break;
                
                case "3" :
                    Console.WriteLine("Enter number of completed tasks: ");
                    int completaTsksNumber = Convert.ToInt32(Console.ReadLine());
                    CompletedTasks(completedTasks, completaTsksNumber);
                    
                    
                    break;
                
                
                
                
                
                
                default:
                    Console.WriteLine("Please enter number between 1 - 5 ");
                    break;

            }
          
            
            
        }


      
    }




    public static void ViewTasks(List<string> completedTasks, string title)
    {
        for (int i = 0; i < completedTasks.Count; i++)
        {
            Console.WriteLine("[x] "+completedTasks[i]);

        }
    }

    public static void CompletedTasks( List<string>task, int nummber)
    {
        int counter =1;
        for (int i = 0; i <=nummber ; i++)
        {
            Console.WriteLine("[()] "+task[i]);
            counter++;
            
        }

        Console.WriteLine("Completed tasks are: " + counter);
    }
    
    
    
}