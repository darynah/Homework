using System;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Передача ссылочных типов по значению.
            Console.WriteLine("***** Passing Person object by value *****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:"); // перед вызовом
            fred.Display();
            SendAPersonByValue(ref fred); //SendAPersonByValue(new Person("Fred", 12))=(fred)
            Console.WriteLine("\n After by value call, Person is:"); // после вызова
            fred.Display();
            Console.ReadLine();
        }

        private static void SendAPersonByValue(ref Person p) // private static void SendAPersonByValue(Person p)
        {
            // Изменить значение возраста в р?
            p.personAge = 99;
            // Увидит ли вызывающий код это изменение?
            p = new Person("Nikki", 99);
            p.Display();
        }
    }
}
