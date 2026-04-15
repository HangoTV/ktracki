namespace buoi12;

public class Gold :item,IEDestruction
{
    public string Size{get;set;}//kich thuoc cua vang
    //isPulled la 1 hinh thai khac cua ispulled tren lop cha 
    public override void isPulled()
    {
        Console.WriteLine("Item's isPulled");
    }

    public override void Greeting()
    {
        base.Greeting();
        Console.WriteLine("Dold's Greeting");
    }
    //ddinhj nghia phan than cho HowToDisappear
    public void HowToDisappear()
    {
        Console.WriteLine("Gold's HowToDisappear");
    }
}