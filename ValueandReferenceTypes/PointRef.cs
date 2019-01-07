using System;

namespace ValueandReferenceTypes
{
  // Классы всегда являются ссылочными типами.
  public class PointRef
  {
 // Те же члены, что и в структуре Point...
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
 public PointRef(int XPos, int YPos)
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