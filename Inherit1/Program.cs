using System;

namespace Inherit1
{
    class Point: IComparable
    {
        public int X;
        public int Y;

        public int CompareTo(object obj)
        {
            var point = (Point)obj;
            var thisDst = Math.Sqrt(X * X + Y * Y);
            var thatDst = Math.Sqrt(point.X * point.X + point.Y * point.Y);
            return thisDst.CompareTo(thatDst);
        }
    }
    static class ArrayExtensions
    {
        public static void Swap(this Array array, int i, int j)
        {
            object obj = array.GetValue(i);
            array.SetValue(array.GetValue(j), i);
            array.SetValue(obj, j);
        }

        public static void BubbleSort(this Array array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    var element1 = (IComparable)array.GetValue(j);
                    var element0 = array.GetValue(j - 1);
                    if (element1.CompareTo(element0) < 0)
                    {
                        array.Swap(j - 1, j);
                    }
                }
        }

        class Program
        {
            static void Main()
            {
                var intArray = new int[] { 12, 5, 7, 8, 9 };
                var stringArray = new string[] { "B", "C", "A", "S" };
                var doubleArray = new double[] { 11, 2, 3 };
                var pointArray = new Point[]
                {
                    new Point() {X = 2, Y = 2},
                    new Point() {X = 1, Y = 1},
                    new Point() {X = 3, Y = 3},

                };
                intArray.BubbleSort();
                doubleArray.BubbleSort();
                stringArray.BubbleSort();
                pointArray.BubbleSort();
            }
        }
    }
}