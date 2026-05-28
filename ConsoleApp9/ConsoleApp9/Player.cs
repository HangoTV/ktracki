namespace ConsoleApp9;

public class Player
{
    public string Name { get; set; }
    public int Tuoi { get; set; }
    
    public  Player(string name, int score, string address)
    {
        Name = name;
        Tuoi = score;
    }
}