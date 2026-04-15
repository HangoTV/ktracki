namespace buoi12;

public class item//base class: dinh nghia item trong game

{
    public float PositionX
    {
        get;
        set;
    }//toa do X

    public float PositionY
    {
        get;
        set;
    }//toa do Y
    public float RotationX
    {
        get;
        set;
    }//xoay X

    public float RotationY
    {
        get;
        set;
    }//xoay y

    public int Value
    {
        get;
        set;
    }//gia tri diem vang $
    public float Weight
    {
        get;
        set;
    }//do nang: da thi nag keo cham

    public void Appear()
    {
        Console.WriteLine("Item's appears");
    }

    public virtual void isPulled()
    {
        Console.WriteLine("Item's isPulled");
    }
}
//da hinh: 1 doi tuong duoc khai bao
//nhung co the duoc ke thua va mo rong them
//cac dac diem khac
