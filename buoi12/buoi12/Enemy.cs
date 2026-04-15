namespace buoi12;

public abstract class Enemy
{
  public abstract void PlayAnimation();//nam doc thi se dung hinh anh nam
  //quai thi dung hinh anh quai
  public abstract bool IsRun();
  public abstract int Health();
  public abstract void Attack();
  public abstract void Move();
  public abstract void Level();
}