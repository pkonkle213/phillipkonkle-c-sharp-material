using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature: ");
            string tempStr = Console.ReadLine();
            Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit? ");
            string type = Console.ReadLine();

            double tempReal = double.Parse(tempStr);
            if (type == "c" || type == "C")
            {
                double tempConverted =tempReal * 1.8 + 32;
                Console.Write(tempReal + "C is " + tempConverted.ToString("0.0") + "F.");
            }
            else if (type == "f" || type == "F")
            {
                double tempConverted = (tempReal - 32) / 1.8;
                Console.Write(tempReal + "F is " + tempConverted.ToString("0.00") + "C.");
            }
        }
    }
}
