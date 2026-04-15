namespace buoi11._2;

public class Gold :Item//ke thua tu class item
{
    public Gold(int value, float weight) : base("Gold", value, weight)
    {
        
    }

    public override int GetGold()
    {
        return Value;// thuoc tinh value la tu lop cha!!!
        
    }
    
}