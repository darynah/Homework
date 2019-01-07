using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Courses
{

  class Program
  {
 public static void Main()
 {
   WriteParabolaMinX(1, 2, 3);
   WriteParabolaMinX(0, 3, 2);
   WriteParabolaMinX(5, 2, 1);
   WriteParabolaMinX(4, 3, 2);
   WriteParabolaMinX(0, 4, 5);
 }
 private static void WriteParabolaMinX(int a, int b, int c)
 {
   if (a == 0 || b == 0 || c == 0)
   {
  Console.WriteLine("Impossible");
   }
   else
   {
  double x = -b / (2.0 * a);
  Console.WriteLine(x);
   }
 }


  }
}
/* //Expr2. Задается натуральное трехзначное число (гарантируется, что трехзначное). 
   //Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
 {
   int a = 356;
   int last = a % 10;
   int b = a / 10;
   int mid = b % 10;
   int first = a / 100;
   Console.WriteLine(last+""+mid+""+first);
   */

/*
 * {
 //Expr1.Как поменять местами значения двух переменных? 
 //Можно ли это сделать без ещё одной временной переменной.Стоит ли так делать?

   int a = 3;
   int b = 4;
   
   Console.WriteLine( a = a + b);
   Console.WriteLine( (b = a - b) + " " + (a = a - b)); // или вместо этого всего Console.WriteLine((a, b) = (b, a));
 }
 */
/*class Program
{

   * Напишите тело метода так, чтобы он возвращал вторую половину строки text,
   * из которой затем удалены пробелы. Можете считать, что text всегда четной длины.

  static void Main()
  {
 Console.WriteLine(GetLastHalf("I love CSharp!"));
 Console.WriteLine(GetLastHalf("1234567890"));
 Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
  }

  public static string GetLastHalf(string text)
  {
 int l = text.Length / 2;
 string cut = text.Substring(l);
 string noSpace = cut.Replace(" ", string.Empty);
 return noSpace;
  }
}*/


