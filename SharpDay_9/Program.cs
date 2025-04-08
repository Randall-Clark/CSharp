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
        double celcius = double.Parse(Console.ReadLine());

        Console.WriteLine("Kelvin = {0}", celcius + 273);
        Console.WriteLine("Fahrenheit = {0}", celcius * 18 / 10 + 32);
    }
}