using System;
using System.Collections.Generic;
 
public static class Program {
    public static void Main() {
        double x0,y0;
        double[] x = new double[1000]; // make x & y
        double[] y = new double[1000];
        int n=0;
        do {
            Console.Write("P{0} (x y) : ",n+1);
            string[] input1 = Console.ReadLine().Split();
            x0 = double.Parse(input1[0]);
            y0 = double.Parse(input1[1]);
            if (x0 != 0 || y0 != 0) {
                x[n] = x0;
                y[n] = y0;
                n++;
            }
        } while (x0 != 0 || y0 != 0);

        if (n < 3) { //check vertex
                throw new Exception ("Vertex < 3.");
        }

        Console.Write("Point K : "); // Receive Point K
        string[] input2 = Console.ReadLine().Split();
        double xk = double.Parse(input2[0]);
        double yk = double.Parse(input2[1]);

        bool ifKIsInside = false; // Check Point K in-outside polygon A
        for (int i = 0, j = n-1; i < n; j = i++) {
            if (((y[i] > yk) != (y[j] > yk)) &&
                (xk < (x[j] - x[i]) * (yk - y[i]) / (y[j] - y[i]) + x[i])) {
                ifKIsInside = !ifKIsInside;
            }
        }

        if (ifKIsInside == true) {
            Console.WriteLine("Inside");
        } else {
            Console.WriteLine("Outside");
        }
    }
}