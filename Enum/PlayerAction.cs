using System;
using System.Diagnostics;

public class Program
{
    enum PlayerAction
    {
        Attack =1,
        Defend =2,
        heal = 3,
        Run = 4
    }

    static void Main()
    {
        Console.WriteLine("Choose an action: ");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Defend");
        Console.WriteLine("3. Heal");
        Console.WriteLine("4. Run");

        string input = Console.ReadLine();
      

            if (int.TryParse(input, out int actionNumber) &&
                Enum.IsDefined(typeof(PlayerAction), actionNumber))
            {
                PlayerAction action = (PlayerAction)actionNumber;

                switch (action)
                {
                    case PlayerAction.Attack:
                        Console.WriteLine("You swing your sword! ");
                        break;
                    case PlayerAction.Defend:
                        Console.WriteLine("You raised your shield");
                        break;
                    case PlayerAction.heal:
                        Console.WriteLine("You are healing");
                        break;
                    case PlayerAction.Run:
                        Console.WriteLine("You run away from battle");
                        break;
                }
            }
            else
            {
                Console.WriteLine("invalid action");

            }
        }
    }


    
