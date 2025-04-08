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
        Console.WriteLine("Enter the number one value:");
        
        int value1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the number two value:");
        
        int value2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{value1} + {value2} = {value1 + value2}");
        Console.WriteLine($"{value1} - {value2} = {value1 - value2}");
        Console.WriteLine($"{value1} * {value2} = {value1 * value2}");
        Console.WriteLine($"{value1} / {value2} = {value1 / value2}");
        Console.WriteLine($"{value1} mod {value2} = {value1 % value2}");
        
    }
}