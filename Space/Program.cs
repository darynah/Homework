using System;

namespace Space
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(RemoveStartSpaces("  two spaces"));
            /*Console.WriteLine(RemoveStartSpaces("	tabs"));
            Console.WriteLine(RemoveStartSpaces("		two	tabs"));
            Console.WriteLine(RemoveStartSpaces("                             many spaces"));
            Console.WriteLine(RemoveStartSpaces("               "));
            Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
            Console.WriteLine(RemoveStartSpaces("a"));
            Console.WriteLine(RemoveStartSpaces(" b"));
            Console.WriteLine(RemoveStartSpaces(" cd"));
            Console.WriteLine(RemoveStartSpaces(" efg"));
            Console.WriteLine(RemoveStartSpaces(" text"));
            Console.WriteLine(RemoveStartSpaces(" two words"));*/
            
            Console.ReadLine();
        }
        public static string RemoveStartSpaces(string text)
        {

            string[] words = text.Split(' ');
            int len = text.Length;
            int flag = 0;
            int k = 1;
            while (k <= len - 1)
            {
                if (char.IsWhiteSpace(text[k]) == true)
                    text = text.Substring(k);
            }
            return text;
            /*while (true)
            {
               if (char.IsWhiteSpace(text[0]) == true)
               text = text.Substring(1+1);
               if (char.IsWhiteSpace(text[0]) == false)
               break;
            }*/

           
        
        }
    }
}
