using System.Diagnostics;
using System.Diagnostics.Contracts;

internal class Program
{
    private static void Main(string[] args)
    {
        //input
        string judul = "Tutorial Design By Contract - Regy Renanda Rahman";
               
        SayaTubeVideo video = new SayaTubeVideo(judul);
        
        //loop play count
        for (int i = 0; i < 10750; i++)
        {
            video.IncreasePlayCount(200000);
        }
        video.PrintVideoDetails();
    }
}

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        //predispostion 
        Debug.Assert(title.Length < 100 && title != null, "Input tidak memenuhi");

        Random random = new Random();
        id = random.Next(10000,100000);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int angka)
    {
        //exception
        try
        {
            checked
            {
                playCount += angka;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID         : "+id);
        Console.WriteLine("Title      : "+title);
        Console.WriteLine("Play Count : "+playCount);
    }
}