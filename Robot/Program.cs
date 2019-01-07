using System;
using System.Reflection.Metadata.Ecma335;

namespace Rubl
{
  class Program
  {
 static void Main(string[] args)
 {
   Console.WriteLine(Rubl(0));
   Console.WriteLine(Rubl(20000));
   Console.WriteLine(Rubl(1));
   Console.WriteLine(Rubl(11));
   Console.WriteLine(Rubl(121));
   Console.ReadLine();
 }


 public static string Rubl(int count)
 {
   string rub;
   int d = count % 100;
   if ((d >= 5) && (d <= 10))
  rub = "рублей";
   else if ((d<=21)&&(d>=99))
  rub = "рублей";
   else rub = "рублей";
   return rub;

   


   /*string b = count.ToString();
   int t = b.Length;
   char symb = b[t-1];
   int r = int.Parse(symb.ToString());
   string rub;
   if (count !=11 && r == 1)
  rub = "рубль";
   else if ((r >= 2) && (r <= 4))
  rub = "рубля";
   else if ((count >=5) && (count<=20))
  rub = "рублей";
   else rub = "рублей";
   return rub;*/
 }
  }
}
