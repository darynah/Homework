using System;
using System.Collections;
using System.Collections.Generic;

namespace Inherit1
{
    class Point
    {
        public int X;
        public int Y;

    }

    class DistanceToZeroComararer : IComparer
    {
        double DistanceToZero(Point point)
        {
            return Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }

        public int Compare(object x, object y)
        {
            return DistanceToZero((Point)x).CompareTo(DistanceToZero((Point)y));
        }
    }

    class XdescendingCompararer : IComparer
    {
        public int Compare(object x, object y)
        {
            return -((Point) x).X.CompareTo(((Point) y).X);
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

        public static void BubbleSort(this Array array, IComparer comparer)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array.GetValue(j);
                    var element0 = array.GetValue(j - 1);
                    if (comparer.Compare(element1,element0) < 0)
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
                
                pointArray.BubbleSort(new DistanceToZeroComararer());
                pointArray.BubbleSort(new XdescendingCompararer());
            }
        }
    }
}