using System;
// Base class
class Animal
{
 public virtual void Sound()
 {
 Console.WriteLine("Animal makes a sound");
 }
}
// Derived classes (demonstrating inheritance)
class Dog : Animal
{
 public override void Sound()
 {
 Console.WriteLine("Dog barks");
 }
}
class Cat : Animal
{
 public override void Sound()
 {
 Console.WriteLine("Cat meows");
 }
}
class Program5
{
 static void Main()
 {
 // Polymorphism using base class reference
 Animal myAnimal;
 myAnimal = new Dog();
 myAnimal.Sound();
 myAnimal = new Cat();
 myAnimal.Sound();
 // Method Overloading (Compile-time Polymorphism)
 Calculator calc = new Calculator();
 Console.WriteLine("\nAddition of 2 numbers: " + calc.Add(5, 10));
 Console.WriteLine("Addition of 3 numbers: " + calc.Add(5, 10, 15));
 }
}
class Calculator
{
 public int Add(int a, int b) => a + b;
 public int Add(int a, int b, int c) => a + b + c;
}