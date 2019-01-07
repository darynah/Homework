using System;

namespace ArrayMulti
{
  class Program
  {
 static void Main(string[] args)
 {
   int[,] matrix = new int[2, 3];

   for (int i = 0; i < matrix.GetLength(0); i++)
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
 matrix[i, j] = 10 * i + j;
  }
   foreach (var e in matrix)
   {
  Console.WriteLine(e);  
   }
   Console.ReadLine();
 }
  }
}
