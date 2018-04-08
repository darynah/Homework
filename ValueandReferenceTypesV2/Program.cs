using System;

namespace ValueandReferenceTypesV2
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeContainingRefType();
        }
        static void ValueTypeContainingRefType()
        {
            // Создать первую переменную Rectangle.
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
            // Присвоить новой переменной Rectangle переменную r1.
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;
            // Изменить некоторые значения в r2.
            Console.WriteLine("-> Changing values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;
            // Вывести значения из обеих переменных Rectangle.
            r1.Display();
            r2.Display();

            Console.ReadLine();
        }
    }
}
