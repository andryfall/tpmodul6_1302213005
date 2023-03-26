// See https://aka.ms/new-console-template for more information

class program
{
    static void Main(string[] args)
    {
        SayaTubeVideo t = new SayaTubeVideo("Tutorial Design By Contract - Andry Nur Falah");
        t.IncreasePlayCount(60);
        t.PrintVideoDetails();
    }
}

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random rand = new Random();
        this.title = title;
        this.id = rand.Next();
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Title Video : " +  this.title);
        Console.WriteLine("Id Video : "+ this.id);
        Console.WriteLine("Durasi : " + this.playCount);
    }
}
