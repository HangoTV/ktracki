namespace buoi12;

public abstract class Trump : Enemy
{
    public override void PlayAnimation()
    {
        Console.WriteLine("Trump Sprite");
    }

    public override bool IsRun()
    {
        return false;
    }

    public override int Health()
    {
        return 100;
    }

    public override void Attack()
    {
        Console.WriteLine("throw bullet!!");
    }
}