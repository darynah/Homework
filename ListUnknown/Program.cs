using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ListUnknown
{
  class Program
  {
 static void Main(string[] args)
 {
   DecodeMessage(new string[]{"будет Трудно конечнО","дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой"});
 }
 private static string DecodeMessage(string[] lines)
 {
   var list = new List<string>();
   foreach (var line in lines)
   {
  foreach (var word in line.Split(' '))
  {
 if (word.Length > 0 && char.IsUpper(word[0]))
 {
   list.Add(word);
 }
  }
 }
   list.Reverse();
   string a;
   a= string.Join(" ", list.ToArray());
   return a;
 }
  }
}

