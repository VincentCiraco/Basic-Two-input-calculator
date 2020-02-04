using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_online
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER two NUMBERS");
            int A1 = int.Parse(Console.ReadLine());
            int B1 = int.Parse(Console.ReadLine());
            Console.WriteLine("choose your function, enter 1 for ADDITION, 2 for SUBTRACTION, 3 for MULTIPLY, and 4 for DIVIDE");
            double Function = double.Parse(Console.ReadLine());
            if Function = 1.0

        }
        public static void FUNction(string Function, double A1, double B1)
        {
            if (double.Parse(Function) = 1)
            {
                 ADDITION(A1,B1);
            }
        }
        public static void ADDITION(double A1, double B1)
        {
            double addResult = (A1 + B1);
            Console.WriteLine($"The sum of your numbers added is {addResult}");
        }
        public static void SUBTRACTION(double A1, double B1)
        {
            double subtractResult = (A1 - B1);
            Console.WriteLine($"The value of your first number subtracted by your second is {subtractResult}");
        }
        public static void MULTIPLY(double A1, double B1)
        {
            double multiplyResult = (A1 * B1);
            Console.WriteLine($"The result of your numbers multiplied is{multiplyResult}");
        }
        public static void DIVIDE(double A1, double B1)
        {
            double divideResult = (A1 / B1);
            Console.WriteLine($"Your fist number divided by your second number is {divideResult}");
        }
    }
}
