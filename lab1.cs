using System;
class Program1
{
 static void Main()
 {
 // Data types
 int a = 10;
 float b = 5.5f;
 double c = 15.75;
 char ch = 'A';
 bool flag = true;
 string name = "BCA Student";
 Console.WriteLine("Integer: " + a);
 Console.WriteLine("Float: " + b);
 Console.WriteLine("Double: " + c);
 Console.WriteLine("Char: " + ch);
 Console.WriteLine("Boolean: " + flag);
 Console.WriteLine("String: " + name);
 // Arithmetic Operators
 int x = 20, y = 6;
 Console.WriteLine("\nArithmetic Operations:");
 Console.WriteLine("Addition: " + (x + y));
 Console.WriteLine("Subtraction: " + (x - y));
 Console.WriteLine("Multiplication: " + (x * y));
 Console.WriteLine("Division: " + (x / y));
 Console.WriteLine("Modulus: " + (x % y));
 // Relational Operators
 Console.WriteLine("\nRelational Operations:");
 Console.WriteLine("x > y: " + (x > y));
 Console.WriteLine("x == y: " + (x == y));
 // Logical Operators
 bool p = true, q = false;
 Console.WriteLine("\nLogical Operations:");
 Console.WriteLine("p && q: " + (p && q));
 Console.WriteLine("p || q: " + (p || q));
 Console.WriteLine("!p: " + (!p));
 }
}