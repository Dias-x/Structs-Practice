using System;
using System.Diagnostics;

//Es wird gezeigt, dass mit dem Struct der Code schneller durchgeführt wird als mit Class.

class Program
{
    static void Main(string[] args)
    {
        Point point = new Point(10, 25);
        point.MovePosition(2,2);
        
        //Stopuhr erstellen
        Stopwatch sw = new Stopwatch();
        
        //Array, für die Zeit erstellen
        Point[] points = new Point[10000000];
        
        //Stopuhr Starten
        sw.Start();
        
        //Array wird durchgeführt
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = new Point(i, i);
        }

        //Array wird zur sicherheit nochmal durchgeführt
        for (int i = 0; i < points.Length; i++)
        {
            points[i].MovePosition(1, 1);
        }
        
        //Stopuhr Stoppen
        sw.Stop();
        
        Console.WriteLine("Fertig");
        //Stopuhr Zeit anzeigen in Milisekunden
        Console.WriteLine($"Zeit: {sw.ElapsedMilliseconds}");
        
    }
}

struct Point
{
    public int x;
    public int y;
    public Point(int _x, int _y)
    {
        x = _x;
        y = _y;
    }
    public void MovePosition(int _x, int _y)
    {
        x += _x;
        y += _y;
    }
}