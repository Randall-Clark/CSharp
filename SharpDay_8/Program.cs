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
        char letterOne = Convert.ToChar(Console.ReadLine());
        char letterTwo = Convert.ToChar(Console.ReadLine());
        char letterThree = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("{0} {1} {2}", letterThree, letterTwo, letterOne);
    }
}