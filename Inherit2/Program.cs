using System;

namespace Inherit2
{
    class Transport
    {
        public double Velocity;
        public double KilometerPrice;
        public int Capacity;
    }
    class CombustionEngineTransport : Transport
    {
        public double EngineVolume;
        public double EnginePower;
    }
    enum ControlType
    {
        Forward,
        Backward
    }
    class Car : CombustionEngineTransport
    {
        public ControlType Control;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            var carAsTransport = (Transport)car;//это upcast
                                                // здесь мы начинаем смотреть на автомобиль просто как 
                                                // на какое-то транспортное средство
            Transport carAsTransport1 = car; //можно писать так. 
                                             // upcast - безопасная процедура, поэтому, как и с конверсией типа
                                             // ее можно не указывать явно
            var car1 = (Car)carAsTransport;  //это downcast
                                             // мы снова начинаем смотреть на автомобиль, как на автомобиль
            var elephant = new Transport();
            //Car wrongCar = (Car)elephant;
            // этот downcast выбросит InvalidCastException, 
            // потому что слон - это не автомобиль.
            // мы не можем смотреть на произвольный транспорт, как на автомобиль
            
            // оператор is позволяет проверить,
            // является ли объект типа Transport 
            // на самом деле автомобилем
            if (elephant is Car)
            {
                Console.WriteLine("Ok, elephant is car");
            }


            /*var c = new Car();
            c.Control = ControlType.Backward;//это собственное поле класса Car
            c.EnginePower = 100;// это поле унаследовано от CombustionEngineTransport
            c.Capacity = 4 // это поле унаследовано от Transport*/
        }
    }
}
