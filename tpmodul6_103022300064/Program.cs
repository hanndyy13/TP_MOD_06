using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(int id, string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Judul tidak boleh null atau kosong.");

        if (title.Length > 100)
            throw new ArgumentException("Judul tidak boleh lebih dari 100 karakter.");

        this.id = id;
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 10000000)
            throw new ArgumentException("Jumlah play count maksimal 10.000.000.");

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer.");
        }
    }

    public void PrintVideoDetails()
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
        try
        {
            SayaTubeVideo video1 = new SayaTubeVideo(1, "Tutorial Design By Contract – Muhammad endihan");
            video1.PrintVideoDetails();

            video1.IncreasePlayCount(5000000);
            video1.PrintVideoDetails();

            SayaTubeVideo video2 = new SayaTubeVideo(2, "Video Overflow Test");
            for (int i = 0; i < 10; i++)
            {
                video2.IncreasePlayCount(1000000000);
            }
            video2.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }
}
