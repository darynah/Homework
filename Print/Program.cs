using System;

namespace Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(1, 2);
            Print("a", 'b');
            Print(1, "a");
            Print(true, "a", 1);
            Console.ReadLine();
        }
        public static void Print(params object[] arguments)
        {
           
            for (var i = 0; i <arguments.Length; i++)
            {
                object obj = arguments.GetValue(i);
                if (i > 0)
                    Console.Write(", ");
                Console.Write(obj);
            }
            Console.WriteLine();
        }
    }
}
