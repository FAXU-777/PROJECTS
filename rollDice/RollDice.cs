using System;
using Lessons;

class Program
{
    static void Main()
    {
        
        Random random = new Random();


        while (true)
        {
            Console.WriteLine("How many dice do u want to roll 1 or 2 ? ");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1":
                    int roll = random.Next(1, 7);
                    Console.WriteLine("You rolled " + roll);

                    
                    break;
                case "2":
                    int roll1 = random.Next(1, 7);
                    int roll2 = random.Next(1, 7);
                    Console.WriteLine("You rolled: " + roll1 +", "+ roll2);

                    int sum = roll1 + roll2;
                    Console.WriteLine("The sum of ur numbers is "+ sum);

                    
                    break;
                case "exit" :
                    Console.WriteLine("Good bye!");
                    return;
                default:
                    Console.WriteLine("Please type '1', '2', or 'exit'.");
                    break;
            }
            
            Console.WriteLine("Write exit if u want to leave");

            Console.WriteLine();
            
        }
    }
}