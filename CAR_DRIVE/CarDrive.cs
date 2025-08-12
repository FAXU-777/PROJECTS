namespace Tasks.cs;

public class Car
{
    private string Name;
    private int Speed;
    private double Fuel;
    private double Odometer;
    private string Color;
    
    

    public Car(string name, int speed, int fuel, string color)
    {
        this.Fuel = fuel;
        this.Name = name;
        this.Speed = speed;
        this.Color = color;
    }

    public string color
    {
        get { return Color; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                value = "White";
            }
            else
            {
                Color = value;
            }
        }
    }

    public string name
    {
        get { return Name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                Name = value;
            }
            else
            {
                Name = "unknown";
            }
        }
    }

    public int speed
    {
        get { return Speed; }
        set
        {
            if (value >= 0 && value <= 300)
            {
                Speed = value;
            }
            else
            {
                Speed = 0;
            }
        }
    }

    public double fuel
    {
        get { return Fuel; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                Fuel = value;
            }
            else
            {
                value = 0;
            }
        }
    }

    public double odometer
    {
        get { return Odometer; }
       private set
        {
            Odometer = value;
        }
    }

    public void Refuel(double liters)
    {
        Fuel = Fuel + liters;
    }

    public void Drive(double km)
    {
        double fuelNeed = km * 0.08;
        if (fuelNeed > Fuel)
        {
            Console.WriteLine("Not enought to drive that far");
            return;
        }

        Fuel = Fuel - fuelNeed;
        Odometer = Odometer + km;
        Console.WriteLine($"Drove {km} km");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Color:{color}, Speed: {speed} km/h, Fuel: {Fuel} L , Odomoeter {Odometer} km");
        
    }

    public void Brake(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Brake amount must be positive");
        }
        Speed = Speed - amount;
        
        if (Speed <=0 )
        {
            Speed = 0;
           
            Console.WriteLine("Car is stopped");
           
        }
        else
        {
            
            Console.WriteLine($"Car slowed down to {Speed} km/h");
            
        }
    }
}