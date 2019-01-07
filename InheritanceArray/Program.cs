using System;
using System.Linq;

namespace InheritanceArray
{
    class Program
    {
        public static void Main()
        {
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };

            Print(Combine(ints, ints));
            Print(Combine(ints, ints, ints));
            Print(Combine(ints));
            Print(Combine());
            Print(Combine(strings, strings));
            Print(Combine(ints, strings));
            Console.ReadLine();
        }

        static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
            
        }
        static Array Combine(params Array[] arrays)
        {
            if (arrays.Length > 0)
            {
                var elementType = arrays[0].GetType().GetElementType();
                var tempelementType = elementType;
                var sametype = true;
                for (int i = 0; i < arrays.Length; i++)
                {
                    
                    elementType = arrays[i].GetType().GetElementType();
                    if (tempelementType == elementType)
                        sametype = true;
                    else
                    {
                        sametype = false;
                    }
                }

                if (sametype == true)
                {
                    var summaryLength = 0;
                    foreach (var arr in arrays)
                    {
                        summaryLength += arr.Length;
                    }
                    var result = Array.CreateInstance(elementType, summaryLength);
                    int currentposition = 0;
                    foreach (var arr in arrays)
                    {
                        Array.Copy(arr, 0, result, currentposition, arr.Length);
                        currentposition += arr.Length;
                    }
                    return result;
                }

                return null;
            }

            return null;
        }
    }
}
