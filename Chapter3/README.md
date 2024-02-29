👉[Chapter 3](../Chapter3/README.md)

## Chapter 3: Abstraction in C#
- [3.1: Introduction to Abstraction](#31-introduction-to-abstraction)
- [3.2: Abstract Classes](#32-abstract-classes)
- [Example](#example)

# 3.1: Introduction to Abstraction
- Abstraction is the process of hiding the implementation details and showing only the functionality to the user. In other words, it deals with the outside view of an object (interface).
- Abstraction is a way to achieve the concept of data hiding. It is used to hide the internal functionality of an object from the outside world.
- Abstraction is achieved using abstract classes and interfaces.

# 3.2: Abstract Classes

- An abstract class is a class that is declared using the `abstract` keyword. It can have abstract methods (methods without a body) and non-abstract methods (methods with a body).
- An abstract class cannot be instantiated. It can only be used as a base class for other classes.
- An abstract class can have fields, properties, constructors, and methods.

# Example
```csharp
using System;

namespace Abstraction
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            circle.Draw();

            Shape rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
```

- In the above example, the `Shape` class is an abstract class with an abstract method `Draw()`. The `Circle` and `Rectangle` classes are derived from the `Shape` class and they override the `Draw()` method.
- The `Main()` method creates objects of the `Circle` and `Rectangle` classes and calls the `Draw()` method on them. The `Draw()` method of the `Circle` and `Rectangle` classes is called, which prints the message to the console.
- The `Shape` class is an abstract class and cannot be instantiated. It is used as a base class for the `Circle` and `Rectangle` classes. The `Draw()` method is an abstract method and must be overridden in the derived classes.


👉[Chapter 4](../Chapter4/README.md)

🔝[Back To Top](#)