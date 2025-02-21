using System;

namespace Debuggers
{
    class Program
    {
        static void Test(string[] args)
        {
            Console.WriteLine("Welcome. Please Enter your name :");
            string name = Console.ReadLine();

            Console.WriteLine($"So your name is : {name}");
        }
    }
}