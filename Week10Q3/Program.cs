using System;
using System.Collections.Generic;
 
public static class Program {
    public static void Main() {
        double x1, y1, x2, y2, r1, r2;
        
        Console.Write("C1 (x y) : ");
        string[] inputC1 = Console.ReadLine().Split();
        x1 = double.Parse(inputC1[0]);
        y1 = double.Parse(inputC1[1]);
        
        Console.Write("C2 (x y) : ");
        string[] inputC2 = Console.ReadLine().Split();
        x2 = double.Parse(inputC2[0]);
        y2 = double.Parse(inputC2[1]);

        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //distance between c1 and c2

        if (x1 == x2 && y1 == y2) {
            throw new Exception("C1 cant be equal to C2.");
        } else {
            Console.Write("Radius of C1 : ");
            r1 = double.Parse(Console.ReadLine());

            Console.Write("Radius of C2 : ");
            r2 = double.Parse(Console.ReadLine());
        
            // if (d == 0 && r1 == r2) {
            //     Console.WriteLine("Circles are coincident and congruent."); //because c1 = c2 and r1 = r2
            // } 

            if (d > r1 + r2) {
                Console.WriteLine("Circles do not intersect."); // Check intersect or not
            } else if (d < Math.Abs(r1 - r2)) {
                Console.WriteLine("One circle is contained within the other."); // Check if a circle is inside another circle.
            } else {
                // Calculate intersection points
                double a = (Math.Pow(r1, 2) - Math.Pow(r2, 2) + Math.Pow(d, 2)) / (2 * d);
                double h = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(a, 2));
                double x3 = x1 + a * (x2 - x1) / d;
                double y3 = y1 + a * (y2 - y1) / d;
                double x4_1 = x3 + h * (y2 - y1) / d;
                double y4_1 = y3 - h * (x2 - x1) / d;
                double x4_2 = x3 - h * (y2 - y1) / d;
                double y4_2 = y3 + h * (x2 - x1) / d;
            
                Console.WriteLine("Intersection points are : ");
                Console.WriteLine("( {0} , {1} )",x4_1,y4_1);
                Console.WriteLine("( {0} , {1} )",x4_2,y4_2);
            }
        }
    }
}