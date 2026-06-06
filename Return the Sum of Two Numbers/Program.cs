//Create a function that takes two numbers as arguments and returns their sum.

using System;
namespace ReturnTheSumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Sum(a, b);
            
        }
        static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }

    }
