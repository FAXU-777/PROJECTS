public class Enemy
{
    private string Name;
    public int Health=100;
    private int AttackPower = 5;
    private bool Pickaxe;
    private int Pickaxedamage = 15;
    

    public Enemy(string name, bool pickaxe)
    {
        this.Name = name;
        this.Pickaxe = pickaxe;
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


    public void Attack(Player player)
    {
        if (Pickaxe)
        {
            player.Health -= Pickaxedamage;
        }
        else
        {
            player.Health -= AttackPower;
        }
        Console.WriteLine($"{player.name} has {player.Health} health");
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
        Console.WriteLine($"Healed {heal} Hp and now has {Health} Hp");
    }
    
    public void Info()
    {
        Console.WriteLine($"Name: {name}, Health: {Health}" );
    }
}