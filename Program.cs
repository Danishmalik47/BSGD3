using System;

namespace Calculator
{
    internal class Program
    {
        public static int Result;
        public static void Add(int A, int B)
        {
            Result = A + B;
        }

        public static void Sub(int A, int B)
        {
            Result = A - B;
        }

        public static void Multiply(int A, int B)
        {
            Result = A * B;
        }

        public static void Divide(int A, int B)
        {
            Result = A / B;
        }

        public static void Main(string[] args)
        {
            Add(50, 50);
            Console.WriteLine("Answer is: " + Result);

            Sub(500, 199);
            Console.WriteLine("Answer is: " + Result);

            Multiply(9, 12);
            Console.WriteLine("Answer is: " + Result);

            Divide(330, 15);
            Console.WriteLine("Answer is: " + Result);


        }
    }
}