using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string numberMaxStr = Console.ReadLine();
            int numberMax = int.Parse(numberMaxStr);

            int firstNum = 0;
            int secondNum = 1;
            int sum = firstNum + secondNum;
            Console.Write("0, 1");

            while (sum <= numberMax)
            {
                Console.Write(", "+sum);
                firstNum = secondNum;
                secondNum = sum;
                sum = firstNum + secondNum;
            }

            Console.ReadLine();
        }
    }
}
