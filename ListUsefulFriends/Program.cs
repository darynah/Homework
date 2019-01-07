using System;
using System.Collections.Generic;

namespace ListUsefulFriends
{
  class Program
  {
 static void Main(string[] args)
 {
   var contacts = new List<string>{ "Паша:pavel.egorov @urfu.ru","Паша: pavel.egorov @urfu.ru","Вася: pavel.egorov @urfu.ru",
  "П: p @p.ru"};
   OptimizeContacts(contacts);
  
 }


 private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
 {
   
   var dictionary = new Dictionary<string, List<string>>();
   foreach (var element in contacts)
   {
 var el = element.Split(':');
 string key = el[0];
 string editkey;
 if (key.Length < 2)
   editkey = key.Substring(0,1);
 else
 {
 editkey = key.Substring(0,2);
 }
 string value = el[1];
 var list = new List<string>();
 list.Add(element);
 
 if (!dictionary.ContainsKey(editkey))
   dictionary.Add(editkey, list);
 else
 {
   dictionary[editkey].Add(element);
 }
   }
   return dictionary;
 }
  }
}
