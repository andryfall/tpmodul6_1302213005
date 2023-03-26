// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Contracts;

class program
{
    static void Main(string[] args)
    {
        SayaTubeVideo t = new SayaTubeVideo("Tutorial Design By Contract - Andry Nur Falah");
        t.IncreasePlayCount(60);
        t.PrintVideoDetails();

        Console.WriteLine(" ");

        SayaTubeVideo tes1 = new SayaTubeVideo("Test Overflow Execption");
        tes1.IncreasePlayCount(60);
        int a = int.MaxValue;
        tes1.IncreasePlayCount(a);
        tes1.PrintVideoDetails();

        Console.WriteLine(" ");

        SayaTubeVideo tes2 = new SayaTubeVideo(null);
        tes2.IncreasePlayCount(60);
        tes2.IncreasePlayCount(100000010);
        tes2.PrintVideoDetails();


    }
}

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title != null && title.Length <= 100);
        Random rand = new Random();
        this.title = title;
        this.id = rand.Next();
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        Contract.Requires(playCount <= 10000000);

        try
        {
            checked
            {
                this.playCount += playCount; ;
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Title Video : " +  this.title);
        Console.WriteLine("Id Video : "+ this.id);
        Console.WriteLine("Durasi : " + this.playCount);
    }
}
