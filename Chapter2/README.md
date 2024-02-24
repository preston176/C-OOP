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
[Car Inheritance](./Car_Inheritance/Program.cs)