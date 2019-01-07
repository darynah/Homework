using System;
using System.Reflection.Metadata.Ecma335;

namespace Year
{
    /*class Program
    {
        private static void Main()
        {
            TestMove("a1", "d4");
            TestMove("f4", "e7");
            TestMove("a1", "a4");
            TestMove("a1", "a1");
            Console.ReadLine();
        }

        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
        }

        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            if ((dy == 0) && (dy == 0))
                return false;
            if ((dx <= 0) || (dx == dy))
                return true;
            else if (dy == dx + 1)
                return true;
            else return false;


        }

    }
}*/


    class Program
    {
        static void Main(string[] args)
        {
            TestMove("a1", "d4");
            TestMove("f4", "e7");
            TestMove("a1", "a4");
            TestMove("a1", "a1");
            Console.ReadLine();
        }

        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
        }

        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            if ((dy == 0) && (dy == 0))
                return false;
            if ((dx <= 0) || (dx == dy))
                return true;
            else if (dy == dx + 1)
                return true;
            else return false;


        }

    }
}

//IF AVERAGE

//class Program
//{
//  static void Main(string[] args)
//  {

// Console.WriteLine(MiddleOf(1, 2, 3)); // => 5
// Console.WriteLine(MiddleOf(1, 3, 2)); // => 12
// Console.WriteLine(MiddleOf(2, 1, 3));
// Console.WriteLine(MiddleOf(2, 3, 1));
// Console.WriteLine(MiddleOf(3, 1, 2));
// Console.WriteLine(MiddleOf(3, 2, 1));
// Console.WriteLine(MiddleOf(2, 2, 2));
// Console.WriteLine(MiddleOf(2, 2, 1));
// Console.WriteLine(MiddleOf(1, 2, 2));
// Console.ReadLine();


//  }

//  public static int MiddleOf(int a, int b, int c)
//  {
// if (a > b)
//   if (b > c)
//  return b;
//   else if (a > c) return c;
//   else return a;
// else if (a > c)
//   return a;
// else if (b > c)
//   return c;
// else
//   return b;
//  }
//}