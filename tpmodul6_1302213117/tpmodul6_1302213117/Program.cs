internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Regy Renanda Rahman");
        video.IncreasePlayCount(1);
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
        Random random = new Random();
        id = random.Next(10000,100000);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int angka)
    {
        playCount += angka;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID         : "+id);
        Console.WriteLine("Title      : "+title);
        Console.WriteLine("Play Count : "+playCount);
    }
}