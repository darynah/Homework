using System;

namespace FunWithArrays
{
  class Program
  {
 static void Main(string[] args)
 {
   Console.WriteLine("***** Fun with Arrays *****");
   //SimpleArrays();
   //ArrayInitialization();
   //ArrayOfObjects();
   RectMultidimensionalArray();
   JaggedMultidimensionalArray();
   Console.ReadLine();
 }
 static void SimpleArrays()
 {
   /*Console.WriteLine("=> Simple Array Creation.");
   // Создать массив int, содержащий 3 элемента с индексами 0, 1, 2.
   int[] myInts = new int[3];
   // Создать массив string, содержащий 100 элементов с индексами 0 — 99.
   string[] booksOnDotNet = new string[100];
   Console.WriteLine();*/
   Console.WriteLine("=> Simple Array Creation.");
   // Создать и заполнить массив из трех целочисленных значений.
   int[] myInts = new int[3];
   myInts[0] = 100;
   myInts[1] = 200;
   myInts[2] = 300;
   // Вывести все значения.
   foreach (int i in myInts)
  Console.WriteLine(i);
   Console.WriteLine();
 }
 static void ArrayInitialization()
 {
   Console.WriteLine("=> Array Initialization.");
   
   // Синтаксис инициализации массива с использованием ключевого слова new.
   string[] stringArray = new string[]
   { "one", "two", "three" };
   Console.WriteLine("stringArray has {0} elements", stringArray.Length);
   
   // Синтаксис инициализации массива без использования ключевого слова new.
   bool[] boolArray = { false, false, true };
   Console.WriteLine("boolArray has {0} elements", boolArray.Length);
   
   // Синтаксис инициализации массива с использованием ключевого слова new и размера.
   int[] intArray = new int[4] { 20, 22, 23, 0 };
   Console.WriteLine("intArray has {0} elements", intArray.Length);

   Console.WriteLine();
 }
 static void ArrayOfObjects()
 {
   Console.WriteLine("=> Array of Objects.");
   // Массив объектов может содержать все что угодно.
   object[] myObjects = new object[4];
   myObjects[0] = 10;
   myObjects[1] = false;
   myObjects[2] = new DateTime(1969, 3, 24);
   myObjects[3] = "Form & Void";
   foreach (object obj in myObjects)
   {
  // Вывести тип и значение каждого элемента в массиве.
  Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
   }
   Console.WriteLine();
 }
 static void RectMultidimensionalArray()
 {
   Console.WriteLine("=> Rectangular multidimensional array.");
   // Прямоугольный многомерный массив.
   int[,] myMatrix;
   myMatrix = new int[6, 6];
   // Заполнить массив (6 * 6).
   for (int i = 0; i < 6; i++)
  for (int j = 0; j < 6; j++)
 myMatrix[i, j] = i * j;
   // Вывести массив (6 * 6).
   for (int i = 0; i < 6; i++)
   {
  for (int j = 0; j < 6; j++)
 Console.Write(myMatrix[i, j] + "\t");
  Console.WriteLine();
   }
   Console.WriteLine();
 }
 static void JaggedMultidimensionalArray()
 {
   Console.WriteLine("=> Jagged multidimensional array.");
   // Зубчатый многомерный массив (т.е. массив массивов).
   
   // Здесь мы имеем массив из 5 разных массивов.
   int[][] myJagArray = new int[5][];
   
   // Создать зубчатый массив.
   for (int i = 0; i < myJagArray.Length; i++)
  myJagArray[i] = new int[i + 7];
   
   // Вывести каждую строку (не забывайте, что каждый элемент имеет
   // стандартное значение 0).
   for (int i = 0; i < 5; i++)
   {
  for (int j = 0; j < myJagArray[i].Length; j++)
 Console.Write(myJagArray[i][j] + " ");
  Console.WriteLine();
   }

   Console.WriteLine();
 }

 }
  }
