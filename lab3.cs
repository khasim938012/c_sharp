using System;
class Program3
{
 // Method to find sum of array elements
 static int SumArray(int[] arr)
 {
 int sum = 0;
 foreach (int val in arr)
 sum += val;
 return sum;
 }
 static void Main()
 {
 // Array demonstration
 int[] numbers = { 10, 20, 30, 40, 50 };
 Console.WriteLine("Array elements:");
 foreach (int n in numbers)
 Console.Write(n + " ");
 Console.WriteLine("\nSum of array: " + SumArray(numbers));
 // 2D Array
 int[,] matrix = { { 1, 2 }, { 3, 4 } };
 Console.WriteLine("\n2D Array:");
 for (int i = 0; i < 2; i++)
 {
 for (int j = 0; j < 2; j++)
 Console.Write(matrix[i, j] + " ");
 Console.WriteLine();
 }
 // String operations
 string str1 = "Hello";
 string str2 = "World";
 string result = str1 + " " + str2;
 Console.WriteLine("\nConcatenated String: " + result);
 Console.WriteLine("Length: " + result.Length);
 Console.WriteLine("Uppercase: " + result.ToUpper());
 Console.WriteLine("Substring: " + result.Substring(0, 5));
 Console.WriteLine("Reversed: " + new string(ToCharArrayReversed(result)));
 }
 static char[] ToCharArrayReversed(string s)
 {
 char[] arr = s.ToCharArray();
 Array.Reverse(arr);
 return arr;
 }
}