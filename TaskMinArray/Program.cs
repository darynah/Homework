using System;

namespace TaskMinArray
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(Min(new[] { '4', '2', '7' }));
            Console.ReadLine();
        }

        static object Min(Array args)
        {
            object minElementArray = args.GetValue(0);
            for (int i = args.Length - 1; i >= 0; i--)
            {
                var elementArray = (IComparable)args.GetValue(i);
                if (elementArray.CompareTo(minElementArray) < 0)
                {
                    minElementArray = elementArray;
                }
            }
            return minElementArray;
        }
    }
}