using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicit conversion trough casting
            int i = 1000;
            byte b = (byte) i;
            Console.WriteLine(b);

            //Explicit conversion trough function Convert. NB : Always put this one into a try and catch for handling errors
            int j = 100;
            byte k = Convert.ToByte(j);
            Console.WriteLine(k);

            //Try Catch Expression to handle errors for non compatible type conversion
            try
            {
                var number = "1234";
                byte by = Convert.ToByte(number);
                Console.WriteLine(by);
            }
            catch (Exception)
            {
                Console.WriteLine("The variable can't be converted");
            }

            //Comparative Operators
            int v1 = 2;
            int v2 = 3;
            int v3 = 4;

            Console.WriteLine(v1 > v3); //false
            Console.WriteLine(v1 == v2);//false
            Console.WriteLine(v3 > v2 && v3 > v1); // true
            Console.WriteLine(v3 > v2 || v2 == v3);// true
            Console.WriteLine(!(v3 > v2 || v2 == v3));// false

            Console.WriteLine("The Project is well done here!");
        }
    }
}