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
        float distance = float.Parse(Console.ReadLine());
        float timeinHours = float.Parse(Console.ReadLine());
        float timeinMinutes = float.Parse(Console.ReadLine());
        float timeinSeconds = float.Parse(Console.ReadLine());
        
        

        Console.WriteLine(" Speed in meters/sec is {0}", distance / (timeinHours * 3600.0f + timeinMinutes * 60 + timeinSeconds));
        Console.WriteLine(" Speed in km/h is {0}", distance / 1000.0f / (timeinHours  + timeinMinutes / 60 + timeinSeconds / 3600.0f));
        Console.WriteLine(" Speed in miles/h is {0}", distance /1609.0f / (timeinHours + timeinMinutes / 60 + timeinSeconds / 3600.0f));

    }
}