using System;

namespace Day19
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            // return the sum of all divisors of n
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += n % i == 0 ? i : 0;
            };
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
