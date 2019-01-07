using System;

namespace ValueandReferenceTypes
{
  public struct Point
  {
 // поля структуры
   public int X;
   public int Y;
   // добавить 1 к позиции X,Y
   public void Increment()
   {
  X++;
  Y++;
   }

   public void Decrement()
   {
  X--;
  Y--;
   }
 // специальный конструктор для структуры
 public Point(int XPos, int YPos)
 {
   X = XPos;
   Y = YPos;
 }

 public void Display()
   {
  Console.WriteLine("X={0},Y={1}", X, Y);
   }
 }



}