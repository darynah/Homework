using System;
using System.Collections.Generic;

namespace Dictionary
{
  class Program
  {
 static void Main(string[] args)
 {
   var array = new[] {"A", "B", "AA", "A", "B", "B"};
   var dictionary = new Dictionary<string,int>();
   dictionary["AB"] = 20;
   //Console.WriteLine(dictionary["AB"]);
   foreach (var str in array)
   {
  if (!dictionary.ContainsKey(str))
 dictionary[str] = 1;
  else
  {
 dictionary[str] = dictionary[str] + 1;
  }
   }

   foreach (var pair in dictionary)
   {
  Console.WriteLine(pair.Key + "\t" + pair.Value);
   }
   Console.ReadLine();


 }
  }
}
