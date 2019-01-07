using System;

namespace ArrayInPow
{
  class Program
  {
 public static void Main()
 {
   var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
   //PrintArray(GetPoweredArray(arrayToPower, 1));
   PrintArray(GetPoweredArray(arrayToPower, 2));
   PrintArray(GetPoweredArray(arrayToPower, 3));
   //PrintArray(GetPoweredArray(new int[0], 1));
   //PrintArray(GetPoweredArray(new[] { 42 }, 0));
   Console.ReadLine();
 }
 public static int[] GetPoweredArray(int[] array, int power)
 {
   int len = array.Length;
   var array2 = new int[len];
   for (int i = 0; i < array.Length; i++)
   {
  array2[i] = (int)Math.Pow(array[i], power);
   }
   
   
   return array2;
 }
 public static void PrintArray(int[] arr)
 {
   foreach (var e in arr)
  Console.WriteLine(e);
 }

  }
}