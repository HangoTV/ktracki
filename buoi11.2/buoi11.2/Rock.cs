namespace buoi11._2;

public class Rock : Item
{
    //ham  khoi tao
    public override int GetGold()
    {
        return _value -(Weight*3) ;//tru tien neu phai keo da
        
    }
}