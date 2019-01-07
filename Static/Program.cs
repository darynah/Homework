using System;

namespace Static
{
    class Algorythm
    {
        int temporalVariable;
        public int Run(int N)
        {
            var result = 0;
            for (temporalVariable = 0; temporalVariable <= N; temporalVariable++)
                result += temporalVariable;
            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var algorythm = new Algorythm();
            Console.WriteLine(algorythm.Run(10));
            Console.ReadLine();
        }
    }
}
