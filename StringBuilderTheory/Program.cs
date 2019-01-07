using System;
using System.Text;

namespace StringBuilderTheory
{
  class Program
  {
 static void Main(string[] args)
 {
   var builder = new StringBuilder();
   builder.Append("Hello");
   builder.Append(" World");
   builder.Append("!");

   var str = builder.ToString();
   Console.WriteLine(str);

   builder.Remove(0, 6);
   str = builder.ToString();
   Console.WriteLine(str);

   builder[5] = '?';
   Console.WriteLine(builder);


   Console.ReadLine();
 }
  }
}
