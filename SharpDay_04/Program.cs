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
        Shelter shelter = new Shelter();

        // Créer un tableau d'animaux
        Animal[] animals = new Animal[]
        {
            new Dog("Rex"),
            new Cat("Luna"),
            new Dog("Buddy"),
            new Cat("Mimi")
        };

        // Appeler la méthode IntroduceAnimal pour chaque animal
        foreach (Animal animal in animals)
        {
            shelter.IntroduceAnimal(animal);
            Console.WriteLine(); // Pour espacer un peu les sorties
        }
    }
}

public class Shelter
{
    public Shelter()
    {
        
    }

    public void IntroduceAnimal(Animal animals)
    {
        animals.MakeSound();
        animals.DisplayInfo();
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
        Console.WriteLine($"I am a Dog name{Name}");
    }
}


public class Cat : Animal
{
    public Cat(String name) : base(name)
    {
        
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"I am a {Name}");
    }
}