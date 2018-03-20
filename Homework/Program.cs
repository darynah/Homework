using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship lodka = new Ship(5,"human_engine");
            lodka.PrintResults();

            Ship kater = new Ship(8, "mechanic");
            kater.PrintResults();

            Ship plot = new Ship(2);
            plot.PrintResults();

            Ship nopeople = new Ship("mechanic");
            nopeople.PrintResults();


        }
    }
}
