using System;

namespace EvenMassiv
{
  class Program
  {
 static void Main(string[] args)
 {
   GetFirstEvenNumbers(30);
   //GetFirstEvenNumbers(0);
   //GetFirstEvenNumbers(1);
   Console.ReadLine();
 }
 public static int [] GetFirstEvenNumbers(int count)
 {
   int[] array = new int[count+1];
   for (int i = 1; i <=count; i++)
   {
  array[i] = i*2;
   }
   
   for (int i = 0; i <= array.Length; i++)
   {
  if (array[i] != 0)
  {
 array[i] = i;
  }
   }
   return array;
 }
 
  }
}
