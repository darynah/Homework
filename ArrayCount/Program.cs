using System;
using System.Collections.Generic;

namespace ArrayCount
{
  class Program
  {
 static void Main(string[] args)
 {
   Console.WriteLine(GetElementCount(new int[] { 0, 100, 1, 2, 100 }, 100));
 }
 public static int GetElementCount(int[] items, int itemToFind)
 {
   List<int> list = new List<int>();
   foreach (var item in items)
  if (item == itemToFind)
  {
 list.Add(item);
  }
   return list.Count ;
 }
  }
}
