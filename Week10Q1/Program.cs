using System;
using System.Collections.Generic;
 
public static class Program {
    public static void Main() {
        Console.Write("P1 (x y) : ");
        string[] inputP1 = Console.ReadLine().Split();
        double x1 = double.Parse(inputP1[0]);
        double y1 = double.Parse(inputP1[1]);

        Console.Write("P2 (x y) : ");
        string[] inputP2 = Console.ReadLine().Split();
        double x2 = double.Parse(inputP2[0]);
        double y2 = double.Parse(inputP2[1]);

        Console.Write("P3 (x y) : ");
        string[] inputP3 = Console.ReadLine().Split();
        double x3 = double.Parse(inputP3[0]);
        double y3 = double.Parse(inputP3[1]);

        double a = x1 - x2;
        double b = y1 - y2;
        double c = x1 - x3;
        double d = y1 - y3;
        double e = ((Math.Pow(x1,2) - Math.Pow(x2,2)) + (Math.Pow(y1,2) - Math.Pow(y2,2))) / 2.0;
        double f = ((Math.Pow(x1,2) - Math.Pow(x3,2)) + (Math.Pow(y1,2) - Math.Pow(y3,2))) / 2.0;

        double det = b * c - a * d;
        double x = (b * f - d * e) / det;
        double y = (c * e - a * f) / det;
        double radius = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));

        Circle2 circle = new Circle2 { X = x, Y = y, Radius = radius };
        Console.WriteLine("Center : ({0}, {1})",circle.X,circle.Y);
        Console.WriteLine("Radius : {0}",circle.Radius);
    }
}