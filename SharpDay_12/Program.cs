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
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}x1 = {1} ",number, number *1);
        Console.WriteLine("{0}x2 = {1}",number, number *2);
        Console.WriteLine("{0}x3 = {1}",number, number *3);
        Console.WriteLine("{0}x4 = {1}",number, number *4);
        Console.WriteLine("{0}x5 = {1}",number, number *5);
        Console.WriteLine("{0}x6 = {1}",number, number *6);
        Console.WriteLine("{0}x7 = {1}",number, number *7);
        Console.WriteLine("{0}x8 = {1}",number, number *8);
        Console.WriteLine("{0}x9 = {1}",number, number *9);
        Console.WriteLine("{0}x10 = {1}",number, number *10);
    }
}