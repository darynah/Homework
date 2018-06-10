using System;

namespace Space
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(RemoveStartSpaces("               "));
            Console.WriteLine(RemoveStartSpaces("  two spaces"));
            Console.WriteLine(RemoveStartSpaces("a"));
            Console.WriteLine(RemoveStartSpaces("               "));
            Console.WriteLine(RemoveStartSpaces(" two words"));
            Console.WriteLine(RemoveStartSpaces("                             many spaces"));
            Console.WriteLine(RemoveStartSpaces("	tabs"));
            Console.WriteLine(RemoveStartSpaces("		two	tabs"));
            Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
            Console.WriteLine(RemoveStartSpaces(" b"));
            Console.WriteLine(RemoveStartSpaces(" cd"));
            Console.WriteLine(RemoveStartSpaces(" efg"));
            Console.WriteLine(RemoveStartSpaces(" text"));
            Console.ReadLine();
        }
        public static string RemoveStartSpaces(string text)
        {
            while (char.IsWhiteSpace(text[0]))
            {
              text = text.Substring(1);
                if (text.Length == 0) break; 
            }
            return text;
        }



            /*my version
            public static string RemoveStartSpaces(string text)
            {
                int n = 0;

                while (true)
                {
                    if (text == "")
                    {
                        return text;
                    }
                    if (char.IsWhiteSpace(text[n]))
                    {
                        text = text.Substring(n + 1);
                    }
                    else if (char.IsWhiteSpace(text[n])!= true)
                    {
                        return text;
                    }
                }       
            }*/
        }
}
