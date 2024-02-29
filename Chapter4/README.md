# Polymorphism in C#

- Polymorphism, enables objects to exhibit different behaviors based on their *types* or *classes*. 
- In C#, polymorphism is achieved through several mechanisms such as method overriding, method overloading, and interface implementations.

## Method Overriding

- Method overriding allows a derived class to provide a specific implementation of a method that is already defined in its base class. This feature enables polymorphic behavior, where a method call on a base class reference may execute a different implementation in the derived class at runtime.

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}
```

## Method Overloading

- Method overloading allows a class to define multiple methods with the same name but different parameter lists. This feature enables polymorphic behavior, where a method call may execute different implementations based on the number and types of arguments passed to it.

### Example of Method Overloading

```csharp
class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public double Add(double x, double y)
    {
        return x + y;
    }
}

```
## Interface Implementation
- Interfaces define a contract that classes can implement. Polymorphism is facilitated through interfaces as different classes can provide their own implementation of the interface methods, allowing for polymorphic behavior.

### Example of Interface Implementation
```csharp 
interface IShape
{
    double CalculateArea();
}

class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}
```

