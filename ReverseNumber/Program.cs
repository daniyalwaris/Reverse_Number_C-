using System;

namespace ReverseNumber
{
    internal class Program
    {
        public class reverseNumber
        {
            public long reverse(long num)
            {
                long temp = 0;
                while (num != 0)
                {
                    temp = (temp * 10) + (num % 10);
                    num = num / 10;
                }
                return temp;
            }
        }

        private static void Main(string[] args)
        {
            long n = 654312;
            reverseNumber inp = new reverseNumber();
            Console.WriteLine("Given number is" + n);
            Console.WriteLine("Reverse of given number is " + inp.reverse(n));
            Console.ReadLine();
        }
    }
}