using System;

namespace PolymorphismToString
{
    class Point : Object
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}",X,Y);
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            var point = new Point {X=1,Y=2};
            Console.WriteLine(point);
            Console.ReadLine();
        }
    }
}