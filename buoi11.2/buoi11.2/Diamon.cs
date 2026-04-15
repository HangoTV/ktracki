namespace buoi11._2;

public class Diamond :Item
{
    //ham khoi tao 
    public Diamond(int value, string weight) : base("Diamond", value, weight)
    {
        
    }

    public override int GetGold()
    {
        return _value * 2;//thuoc tinh value la tu lopm chja
        
    }
}