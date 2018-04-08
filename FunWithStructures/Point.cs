using System;

namespace FunWithStructures
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

            public void Display()
            {
                Console.WriteLine("X={0},Y={1}", X, Y);
            }
        }
    }