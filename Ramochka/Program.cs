using System;

namespace Ramochka
{
    class Program
    {
        public static void Main()
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
            Console.ReadLine();
        }
        private static void WriteTextWithBorder(string text)
        {
            string top = "-";
            int t = text.Length;

            Console.Write("+-");
            for (int i =0; i <t; i++)
                Console.Write(top);
            Console.WriteLine("-+");

            Console.WriteLine("| "+ text + " |");

            Console.Write("+-");
            for (int i = 0; i < t; i++)
                Console.Write(top);
            Console.WriteLine("-+");
        }
    }
}
