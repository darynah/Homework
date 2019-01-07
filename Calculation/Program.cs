using System;

namespace Calculation
{
  class Program
  {
 static void Main(string[] args)
 {
   string userInput;
   userInput = Console.ReadLine();
   Console.WriteLine(Calculate(userInput));
 }

 public static double Calculate(string userInput)
 {
   var parts = userInput.Split();
   double sum = double.Parse(parts[0]);
   double nominal = double.Parse(parts[0]);
   double percent = double.Parse(parts[1]);
   double time = double.Parse(parts[2]);
   for (int i = 0; i < time; i++)
   {
  sum += sum * percent / 100.0 + nominal / 12.0;
   }
   Console.Write(sum);
   return sum;
 }
  }
 }

