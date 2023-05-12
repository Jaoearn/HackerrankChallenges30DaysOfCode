using System;

namespace Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            try
            {
                var result = Convert.ToInt32(S);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
