using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

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
        
    }
}

public abstract class Animal
{
    public string Name { get; set; }

    public Animal(String name)
    {
        Name = name;
    }

    public abstract void MakeSound();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"I am a {Name}");
    }
}

public class Dog : Animal
{
    public Dog(String name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"I am a {Name}");
    }
}


public class Cat : Animal
{
    public Cat(String name) : base(name)
    {
        
    }

    public override void MakeSound()
    {
        throw new NotImplementedException();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"I am a {Name}");
    }
}