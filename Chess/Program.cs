using System;

namespace Chess
{
  class Program
  {
 static void Main(string[] args)
 {
   WriteBoard(8);
   WriteBoard(1);
   WriteBoard(2);
   WriteBoard(3);
   WriteBoard(10);
   Console.ReadLine();
 }
 private static void WriteBoard(int size)
 {
   string a = "#";
   string b = ".";
   for (int i = 1; i <= size; i++)
   {
  for (int k = 1; k <= size; k++)
  {
 if ((k%2 == 0 && i%2 == 0)||(k % 2 != 0 && i % 2 != 0))
 Console.Write(a);
 else
 Console.Write(b);
  }
  Console.WriteLine();
   }
   Console.WriteLine();
 }
  }
  
}
  

