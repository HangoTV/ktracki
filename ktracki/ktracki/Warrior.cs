namespace ktracki;

public class Warrior :Character
{
    public int AttackDamage{ get; set;}
    public string Weapon{ get; set;}

    public Warrior(
        int id,
        string name,
        int attackDamage,
        string weapon
    ) : base(id, name)
    {
        AttackDamage = attackDamage;
        Weapon = weapon;
    }

    public int Power()
    {
        return Level * AttackDamage;
    }

    public override void Display()
    {
        Console.WriteLine($"ID :{Id}");
        Console.WriteLine($"Name :{Name}");
        Console.WriteLine($"Level :{Level}");
        Console.WriteLine($"Health :{Health}");
        Console.WriteLine($"AttackDamage: {AttackDamage}");
        Console.WriteLine(($"Weapon: {Weapon}"));
        Console.WriteLine(($"Power: {Power()}"));
    }
}