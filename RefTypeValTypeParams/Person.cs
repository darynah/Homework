﻿using System;

namespace RefTypeValTypeParams
{
    public class Person
    {
        public string personName;
        public int personAge;
        // Конструкторы.
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }
}