namespace ktracki;

public class Character
{
    public int Id{get;set;}
    public string Name{get;set;}
    public int Level{get;set;}
    public int Health{get;set;}

    public Character()
    {
        
    }

    public Character(int id, string name, int level, int health)
    {
        Id = id;
        Name=name;
        Level=level;
        Health=health;
    }

    protected Character(int id, string name)
    {
        throw new NotImplementedException();
    }

    public void Input()
    {
        Console.WriteLine("Nhap ID: ");
        Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap Name: ");
        Name = Console.ReadLine();
        Console.WriteLine("Nhap Level: ");
        Level = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap Health: ");
        Health = int.Parse(Console.ReadLine());
    }

    public virtual void Display()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nhap Name: {Name}");
        Console.WriteLine($"Nhap Level: {Level}");
        Console.WriteLine($"Nhap Health: {Health}");
    }

    public object LaySucManh()
    {
        throw new NotImplementedException();
    }
}