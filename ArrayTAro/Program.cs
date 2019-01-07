using System;

namespace ArrayTaro
{
  class Program
  {
 enum Suits
 {
   Wands,
   Coins,
   Cups,
   Swords
 }
 static void Main(string[] args)
 {
   // тестовый код:
   for (int i = 0; i < 4; i++)
   {
  Console.WriteLine(GetSuit((Suits)i));
   }
 }
 private static string GetSuit(Suits suit)
 {
   return new string[4] { "жезлов", "монет", "кубков", "мечей" } [(int)suit];
 }
  }
}
