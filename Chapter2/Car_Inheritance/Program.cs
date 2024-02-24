using System;

class Car 
{
    public string name;
    public void Honk()
    {
        Console.WriteLine("Booop");
    }
}
// Inheritance 
class Toyota : Car {
    public string model;
}

class Program 
{
    static void Main()
    {
        Toyota car1 = new Toyota();

        car1.model = "Probox";
        car1.name =  "Toyota";
        car1.Honk();
        Console.WriteLine("Car model: " + car1.model);
        Console.WriteLine("Car name: " + car1.name);

    }
}
