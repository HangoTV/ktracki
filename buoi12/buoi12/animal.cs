namespace buoi12;

public abstract class animal
{
    //tap trung vao  viec dinh nghia doi tuong co the lam gi
    //ma ko phai la lam nhu the nao
    public abstract string Name { get; }
    public abstract bool IsRun();//co the chay
    public abstract void IsFly();
    public abstract int NumberOfLegs();
}