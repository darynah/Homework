using System;

namespace ArrayIndex
{
  class Program
  {
 public static void Main()
 {
   Console.WriteLine(MaxIndex(new double[] { 1, 2, 3 }));
   Console.WriteLine(MaxIndex(new double[] { }));
   Console.WriteLine(MaxIndex(new double[] { 1 }));
   Console.WriteLine(MaxIndex(new double[] { 0, 100, 1, 2, 100 }));
   Console.WriteLine(MaxIndex(new double[] { 1, 2, 3, 100, 4, 5, 6 }));
   Console.WriteLine(MaxIndex(new double[] { 100, 100, 100, 100 }));
   //Console.WriteLine(MaxIndex(CreateSecretBigArray1()));
   //Console.WriteLine(MaxIndex(CreateSecretBigArray2()));
   Console.ReadLine();
   
 }
 public static int MaxIndex(double[] array)
 {
   int max = 1;
   foreach (var item in array)
  if (item > max) max = (int)item;
   int indexMax = Array.IndexOf(array, max);
   return indexMax;

 }
   
  }
}
