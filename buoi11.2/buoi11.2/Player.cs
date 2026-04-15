public class Player // class là tu khoa,lop Player
{
    private int score;
    private string name;
    private float x_position;
    private float y_position;
    //PROPERTY
    public int Score
    {
        get=>score;
        set=>score=value;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }
     
    public float X_position {
        get => x_position;
        set => x_position = value;
    }
    public float Y_position{
        get => y_position;
        set => y_position = value;
    }
    public void Move(int x,int y){
        Console.WriteLine("x= "+ "- "+y);
        }

    public void AddScore(int value)
    {
        this.score += value;
        Console.WriteLine("score = " + score);
    }
}