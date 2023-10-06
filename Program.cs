using System;

namespace Methods
{
    internal class Program
    {
        private static int Result;

        public static void Addition(int A, int B)
        {
            Result = A + B;
        }

        public static void Subtraction(int A, int B)
        {
            Result = A - B;
        }

        public static void Multiplication(int A, int B)
        {
            Result = A * B;
        }

        public static void Division(int A, int B)
        {
            Result = A / B;
        }

        public static void Pass(int A)
        {
            if (A > 30)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public static void AGrade(int A)
        {
            if (A >= 90)
            {
                Console.WriteLine("A+ Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static void BGrade(int A)
        {
            if (A >= 70)
            {
                Console.WriteLine("B Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static void CGrade(int A)
        {
            if (A >= 60)
            {
                Console.WriteLine("C Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public static void DGrade(int A)
        {
            if (A >= 50)
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private static void Fail(int A)
        {
            if (A <= 49)
            {
                Console.WriteLine("F Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public static void Main(string[] args)
        {
            Pass(91);
            AGrade(91);
            Pass(86);
            BGrade(86);
            Pass(69);
            CGrade(69);
            Pass(55);
            DGrade(56);
            Fail(15);
            Fail(15);
        }
    }
}