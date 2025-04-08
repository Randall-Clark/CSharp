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
        Car car1 = new Car("Continental GT", "Bentley", 2022, 100);
        Car car2 = new Car("Escalade", "Cadillac", 2025, 10);
        Car car3 = new Car("GLS Mayback", "Mercedes");
        Car car4 = new Car("Van", "Toyota");
        Car car5 = new Car("Fusion", "Ford");

        car1.DisplayInfo();
        car2.DisplayInfo();
        car3.DisplayInfo();
        car4.DisplayInfo();
        car5.DisplayInfo();
        Console.WriteLine(Car.carsNumber);
    }
}

class Car
{
    public String model;
    public String brand;
    public int years;
    double kilometers;
    
    public static int carsNumber;

    public Car(String model, String brand, int years, double kilometers)
    {
        this.model = model;
        this.brand = brand;
        this.years = years;
        this.kilometers = kilometers;
        carsNumber++;
    }
    
    public Car(String model, String brand)
    {
        Car car = new Car(model, brand, 2020, 0);
        this.model = model;
        this.brand = brand;
        this.years = 2020;
        this.kilometers = 0;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Model : {this.model}, brand {this.brand}, years {this.years}, kilometers : {this.kilometers}");
    }

}