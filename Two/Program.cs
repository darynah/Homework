using System;

namespace Two
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
            Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(100));

            Console.ReadLine();

        }
        private static int GetMinPowerOfTwoLargerThan(int number)
        {
           int result = 1;


            while (result < number)
            {
                if (number < 0)
                    break;

                result = 2 * result;
                double logarifm = Math.Log(number, 2);
                if (logarifm == 1)
                    logarifm = 1;
                if (logarifm % 1 == 0)
                    logarifm += 1;
                else
                    logarifm = Math.Ceiling(logarifm);
                double b = Math.Pow(2, logarifm);

                result = (int) b;
            }

            return result;
            
        }
    }
}
