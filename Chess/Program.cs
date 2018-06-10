using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBoard(2);
            /*WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);*/
            Console.ReadLine();
        }
        private static void WriteBoard(int size)
        {
            string a = "*";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    a += a;
                    Console.WriteLine(a);
                }
            }     
            Console.Write(a);
        }
    }
}