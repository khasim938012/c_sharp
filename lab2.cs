using System;
class Program2
{
 static void Main()
 {
 // if-else: check even or odd
 int num = 15;
 if (num % 2 == 0)
 Console.WriteLine(num + " is Even");
 else
 Console.WriteLine(num + " is Odd");
 // switch case: grade calculator
 char grade = 'B';
 switch (grade)
 {
 case 'A':
 Console.WriteLine("Excellent");
 break;
 case 'B':
 Console.WriteLine("Good");
 break;
 case 'C':
 Console.WriteLine("Average");
 break;
 default:
 Console.WriteLine("Invalid Grade");
 break;
 }
 // for loop: print 1 to 10
 Console.WriteLine("\nFor Loop:");
 for (int i = 1; i <= 10; i++)
 Console.Write(i + " ");
 // while loop: sum of first 5 numbers
 Console.WriteLine("\n\nWhile Loop:");
 int sum = 0, j = 1;
 while (j <= 5)
 {
 sum += j;
 j++;
 }
 Console.WriteLine("Sum of first 5 numbers: " + sum);
 // do-while loop
 Console.WriteLine("\nDo-While Loop:");
 int k = 1;
 do
 {
 Console.Write(k + " ");
 k++;
 } while (k <= 5);
 }
}