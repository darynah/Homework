
using System;

namespace ArrayInArray
{
  class Program
  {
 public static void Main()
 {
   /*Console.WriteLine(FindSubarrayStartIndex(new[] { 100, 100, 100, 100 }, new[] { 100, 100 }));
   Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new[] { 2 }));
   Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new[] { 2, 3 }));
   Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new[] { 1, 2 }));
   Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
   Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new[] { 1, 3 }));
   Console.WriteLine(FindSubarrayStartIndex(new[] { 1 }, new[] { 1, 2, 3 }));
   Console.WriteLine(FindSubarrayStartIndex(new int[0], new[] { 1, 2, 3 }));*/
   Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new int[0]));
   Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 1, 2, 3 }, new[] { 1, 2, 3 }));
   Console.WriteLine(FindSubarrayStartIndex(new int[0], new int[0]));
   Console.ReadLine();
 }

 public static int FindSubarrayStartIndex(int[] array, int[] subArray)
 {
   for (int i = 0; i < array.Length - subArray.Length + 1; i++)
  if (ContainsAtIndex(array, subArray, i)) return i;
   return -1;
 }

 public static bool ContainsAtIndex(int[] array, int[] subArray, int i)
 {
   if (array.Length == 0 || subArray.Length == 0)
   {
  return true;
   }
   int k = subArray.Length;
   if ((array.Length - i>=k) && k >=0 && array.Length >=0 && subArray.Length >0)
   {
  if (array[i] == subArray[0])
  {
 for (int l = 1; l < k; l++)
 {
   if (array[i + l] != subArray[l])
   {
  return false;
   }
 }
 return true;
  }
  return false;
   }
   return false;
 }
  }
}
