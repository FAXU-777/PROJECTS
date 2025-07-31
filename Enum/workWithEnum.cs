
public class Program
{
    enum GameDifficulty
    {
        Easy = 1,
        Normal = 2,
        Hard = 3,
        Insane = 4
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose Difficulty: Easy, Normal, hard or insane");
        string input = Console.ReadLine();
        if (Enum.TryParse(input, true, out GameDifficulty difficulty))
        {
            Console.WriteLine($"You choose: {difficulty} ({(int)difficulty})");

            switch (difficulty)
            {
                case GameDifficulty.Easy:
                    Console.WriteLine("Enjoy your relaxing game");
                    break;
                case GameDifficulty.Normal:
                    Console.WriteLine("Good luck, gamer");
                    break;
                case GameDifficulty.Hard:
                    Console.WriteLine("Now things gets serious");
                    break;
                case GameDifficulty.Insane:
                    Console.WriteLine("You must love pain dude ;)");
                    break;
                default:
                    Console.WriteLine("Enter correct");
                    break;
            }
        }
        else
            {
                Console.WriteLine("Invalid difficulty");
            }
        }

    }
    
