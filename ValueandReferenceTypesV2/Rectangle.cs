using System;

namespace ValueandReferenceTypesV2
{
  public struct Rectangle
  {
 // Структура Rectangle содержит член ссылочного типа.
 public ShapeInfo rectInfo;
 public int rectTop, rectLeft, rectBottom, rectRight;
 public Rectangle(string info, int top, int left, int bottom, int right)
 {
   rectInfo = new ShapeInfo(info);
   rectTop = top; rectBottom = bottom;
   rectLeft = left; rectRight = right;
 }
 public void Display()
 {
   Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
   "Left = {3}, Right = {4}",
  rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
 }
  }
}