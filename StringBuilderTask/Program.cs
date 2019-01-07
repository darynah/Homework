using System;
using System.Text;

namespace StringBuilderTask
{
  class Program
  {
 static void Main(string[] args)
 {
   var commands = new string[]{"push Привет! Это снова я! Пока!", "pop 5","push Как твои успехи? Плохо?","push qwertyuiop",
  "push 1234567890","pop 26"};
   Console.WriteLine(ApplyCommands(commands));
   Console.ReadLine();
 }
 private static string ApplyCommands(string[] commands)
 {
   string result = null;
   var builder = new StringBuilder();
   foreach (var str in commands)
   {
  if (str.Contains("push"))
  {
 builder.Append(str.Remove(0, 5));
  }

  if (str.Contains("pop"))
  {
 commands[0] = str.Remove(0, 4);
 int t = int.Parse(commands[0]);
 builder.Remove((builder.Length - t),t);

  }
  result = builder.ToString();
   }
   return result;
 }   
  }
}
