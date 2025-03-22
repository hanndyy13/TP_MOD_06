using System;
using System.Diagnostics.Metrics;
public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(int id, string title, int playCount)
    {
        this.id = id;
        this.title = title;
        this.playCount = playCount;
    }

    public void IncreasePlayCount(int count) // Changed to public
    {
        if (count < 0)
        {
            Console.WriteLine("Error: Jumlah penambahan play count tidak boleh negatif.");
            return;
        }
        playCount += count;
    }

    public void PrintDetailVideo() // Changed to public
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}

public class Program
{
    public static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo(1, "Tutorial Design By Contract – Muhammad Endihan", 5);
        video.IncreasePlayCount(10); 
        video.PrintDetailVideo();   
    }
}
