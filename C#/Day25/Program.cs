using System;

namespace Day25
{
    class Program
    {
        public static bool isPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                if (number % divisor == 0)
                    return false;
            return true;
        }
        static void Main(String[] args)
        {
            int times = int.Parse(Console.ReadLine());
            while (times-- > 0)
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(isPrime(input) ? "Prime" : "Not prime");
            }
        }
    }
}
