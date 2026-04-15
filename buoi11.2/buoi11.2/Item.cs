namespace buoi11._2;

public class Item
{
    private string _name;
    protected int _value;
    private int _weight;
    public string Name => _name;
    public int Value => _value;
    public int Weight => _weight;

    public Item(string name, int value, int weight)
    {
        this._name = name;
        this._value = value;
        this._weight = weight;
    }
    public virtual int GetGold()
    {
        return _value;
    }
}