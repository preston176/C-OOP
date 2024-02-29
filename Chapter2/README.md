👉[Chapter 1](../Chapter1/README.md)

# Chapter 2: Real World Examples of Objects and Classes

- Let us consider a **Car** as an entity

## How can we define objects? (The Car?)

- We will need a blueprint of the car

- using this blueprint, we can create n number of cars

## What is the Class

- The blueprint of the object (car), that contains variables for storing data and functions for performing methods on the data.

## What is the object

- The instance of a class

- it has 
    1. methods - Start(), Drive(), Stop()
    2. variables - Car Name, Model, Price, Type etc.

### Types of Classes

- Base Class
- Derived Class

#### Syntax
```
class BaseClass
{
    // Base class members and methods
}

class DerivedClass : BaseClass
{
    // Additional members and methods specific to DerivedClass
}
```

### Example
- Run the following code to see the output
```csharp
﻿using System;

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
```

👉[Chapter 3](../Chapter3/README.md)

🔝[Back To Top](#)