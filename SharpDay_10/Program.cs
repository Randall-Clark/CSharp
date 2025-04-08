using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/

class Program
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter: {0}", width * 2 + height * 2);
        Console.WriteLine("Area: {0}", width * height);
        Console.WriteLine("Diagonal: {0}", Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2)));
    }
}