using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack (string title)
    {
        Debug.Assert(title != null, "Judul track tidak berupa null");
        Debug.Assert(title.Length <= 100, "Judul track memiliki panjang maksimal 100 karakter");

        if (title == null || title.Length > 100)
        {
            Console.WriteLine("Error: Judul Tidak Valid!");
            return;
        }

        this.title = title;
        this.playCount = 0;

      
        Random random = new Random(); 
        this.id = random.Next(10000, 99999);  

        }
    public void IncreasePlayCount (int count)
    {
        Debug.Assert(count <= 10000000, "Maksimal 10.000.000");

        try
        {
            checked
            {
                playCount = playCount + count;
            }

        }

        catch (OverflowException)
        {
            Console.WriteLine("Terjadi Overflow!");
        }
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
        try { 
            SayaMusicTrack lagu1 = new SayaMusicTrack("Young and Beautiful");
            lagu1.IncreasePlayCount(5000000);
            lagu1.PrintTrackDetails();

            //Ini judul yang lebih dari 100 karakter
            //SayaMusicTrack lagu2 = new SayaMusicTrack("Aihh aku mencoba untuk menulis judul yang sangat
            //                       panjang atau lebih dari 100 apakah bisa berjalan programnya");

            SayaMusicTrack lagu3 = new SayaMusicTrack("Overflow Test");

            for (int i = 0; i < 300; i++)
            {
                lagu3.IncreasePlayCount(10000000);
            }
            lagu3.PrintTrackDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}