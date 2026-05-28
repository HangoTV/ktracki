namespace ktracki;

public class Mage : Character
{
    public int Mana { get; set; }
    public int MagicDamage { get; set; }

    public Mage(
        int id,
        string name,
        int mana,
        int magicDamage
    ) : base(id, name)
    {
        Mana = mana;
        MagicDamage = magicDamage;
    }
    public int PowerMagic()
    {
        return Level * MagicDamage;
    }

    public override void Display()
    {
        Console.WriteLine($"ID :{Id}");
        Console.WriteLine($"Name :{Name}");
        Console.WriteLine($"Level :{Level}");
        Console.WriteLine($"Health :{Health}");
        Console.WriteLine($"Mana: {Mana}");
        Console.WriteLine(($"Magic Damage: {MagicDamage}"));
        Console.WriteLine(($"Power: {PowerMagic()}"));
    }
}