namespace buoi12;

public class Rock :item
{
    public override void isPulled()
    {
        base.isPulled();//goi isPullled cua lp cha
        Console.WriteLine("Rock's isPulled");
    }
}