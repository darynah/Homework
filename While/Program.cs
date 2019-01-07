using System;

namespace While
{
  class Program
  {
 static void Main(string[] args)
 {
   int sum = 0;
   while(true)
   {
  var line = Console.ReadLine();
  if (line == "") break;
  sum += int.Parse(line);
   }
   Console.WriteLine(sum);
 }
  }
}
