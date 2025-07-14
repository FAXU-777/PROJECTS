using first.NewDirectory1;

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        
        Console.WriteLine("Enter car brand: ");
        string brandInput = Console.ReadLine();

        while (int.TryParse(brandInput, out _))
        {
            Console.WriteLine("Invalid input! Please enter a brand name, not a number.");
            Console.WriteLine("Enter car brand: ");
            brandInput = Console.ReadLine();
        }

        car.brand = brandInput;

        
        
        Console.WriteLine("Enter car model: ");
        string model = Console.ReadLine();
        while (int.TryParse(model, out _))
        {
            Console.WriteLine("Invalid input! Please enter a brand name, not a number.");
            Console.WriteLine("PLease enter car model");
            model = Console.ReadLine();

        }
        car.model = model;
        
        
        Console.WriteLine("Enter car year: ");
        string carYear = Console.ReadLine();
        while (!int.TryParse(carYear, out _))
        {
            Console.WriteLine("Please enter year!");
            carYear = Console.ReadLine();
        }

        car.year = Convert.ToInt32(carYear);

     

        while (true)
        {
            Console.WriteLine("Car Menu");
            Console.WriteLine("1. Drive");
            Console.WriteLine("2. Brake");
            Console.WriteLine("3. Display info");
            Console.WriteLine("4. Exit");
            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    car.Drive();
                    Console.WriteLine("Car is driving. "+"Current speed: "+car.speed +" Km/h" );
                    break;
                case 2:
                    car.Brake();
                    var carIsBraking = $"car is braking." + $"Current speed: {car.speed}" + " Km/h";
                    Console.WriteLine(carIsBraking);
                    break;
                case 3:
                    Console.Write("Car speed is: "+ car.speed +". Car info: ");

                    car.DisplayInfo();
                    break;
                case 4:
                    var goodBye = $"good bye";
                    Console.WriteLine(goodBye);
                    return;
                default:
                    Console.WriteLine("Enter number between 1 - 4");
                    break;
            }
        }






    }
}