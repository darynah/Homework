using System;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***A First look at structures***\n");
            Point myPoint;
            myPoint.X = 249;
            myPoint.Y = 52;
            myPoint.Display();
            // скорректировать значения X,Y
            myPoint.Increment();
            myPoint.Display();
            myPoint.Decrement();
            myPoint.Display();
            
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;
            p1.Display();

            Point p2 = new Point();
            p2.Display();

            Console.ReadLine();
        } 
    }
}
