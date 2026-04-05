using System;
using System.Reflection;
using System.Runtime.CompilerServices;

public class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack (string title)
    {
    this.title = title;
    this.playCount = 0;

    Random random = new Random(); 
    this.id = random.Next(10000, 99999);  
    }

    public void IncreasePlayCount (int count)
    {
    playCount = playCount + count;
    }

    public void PrintTrackDetails()
    {
    Console.WriteLine("ID: " + id);
    Console.WriteLine("Title: " + title);
    Console.WriteLine("Play Count: " + playCount);
        Console.WriteLine("=====================");
    }
}


public class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("Young and Beautiful");
        SayaMusicTrack lagu2 = new SayaMusicTrack("Flashlight");

        lagu1.IncreasePlayCount(10);
        lagu2.IncreasePlayCount(20);

        lagu1.PrintTrackDetails();
        lagu2.PrintTrackDetails();
    }
}