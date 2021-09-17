using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in a series of decimal values (separated by spaces): ");
            string decimalValuesStr = Console.ReadLine();

            string[] individualNums = decimalValuesStr.Split(" ");
            for (int i = 0; i < individualNums.Length; i++)
            {
                int binary = int.Parse(individualNums[i]);
                Console.WriteLine(individualNums[i] + " in binary is " + Convert.ToString(binary, 2));
            }
        }
    }
}
