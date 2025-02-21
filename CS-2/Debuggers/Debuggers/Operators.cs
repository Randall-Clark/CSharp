using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            double doubleValue = 10.0;

            //Addition Operator (+)
            value = value + 1; //Standard wrtiting
            value += 1; //Shortcut Writting;
            value ++; //Increment only value by 1 and it's best to use in loops;

            
            //Addition Operator (-)
            value = value - 1; //Standard wrtiting
            value -= 1; //Shortcut Writting;
            value --; //Decrement only value by 1 and it's best to use in loops;

            //Multiply Operator (*)
            value = value * 2;
            value *= 2;

            //Divide Operator (/) When doing division best practice is to use double or decimal to get decimal result
            //------> doubleValue = Convert.ToDouble(value) / 2 <------; use this one only the doubleValue have yet to be declared.
            doubleValue = doubleValue / 2;
            doubleValue /= 2;

            //Modulo Operator (%) : Returns the remainder of the division of the value by the number after it.
            value = value % 2; // This gives you 0
        }
    }
}