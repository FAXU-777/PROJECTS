public class Player
{
    private string Name;
    public int Health=100;
    private int AttackPower = 5;
    private bool Sword;
    public int SwordDamage = 15;
    

    public Player(string name,bool sword )

    {
        this.Name = name;
        this.Sword = sword;
        
    }
    
    public string name
    {
        get { return Name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Name = value;
            }
        }
        
    }

    public void Attack(  Enemy enemy )
    {
        if (Sword)
        {
            enemy.Health = enemy.Health - SwordDamage;
        }
        else
        {
            enemy.Health = enemy.Health - AttackPower ;
        }
       
        Console.WriteLine($"{enemy.name} has {enemy.Health} health");
        
    }

    public void Heal(int heal)
    {
        if (heal < 0)
        {
            Console.WriteLine("It must be positive");
            return;
        }
       
        Health += heal;
        if (Health >= 100)
        {
            Health = 100;
        }
      
    }

    public void Info()
    {
        Console.WriteLine($"Name: {name}, Health: {Health}" );
    }
}