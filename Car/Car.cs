namespace first.NewDirectory1;

public class Car
{
    public string brand;
    public string model;
    public int year;
    public int speed = 0;
    public Car()
    {
        
    }

    public Car(string brand, string model, int year)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        
    }
    public void Drive()
    {
        speed = speed + 10;
    }

    public void Brake()
    {
        if (speed >= 10)
            speed = speed - 10;
        else
            speed = 0;
    }

    public void DisplayInfo()
    {
        Console.WriteLine(brand +" " + model + " "+ year );
    }
    
}: