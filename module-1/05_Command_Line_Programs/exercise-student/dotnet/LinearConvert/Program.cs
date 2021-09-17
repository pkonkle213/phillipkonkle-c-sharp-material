using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");
            string lengthStr = Console.ReadLine();
            Console.Write("Is the measurement in (m)eter, or (f)eet? ");
            string type = Console.ReadLine();

            double length = double.Parse(lengthStr);
            if (type == "m" || type == "M")
            {
                double lengthConverted = length * 3.2808399;
                Console.Write(length + "m is " + lengthConverted.ToString("0.0000") + "f.");
            }
            else if (type == "f" || type == "F")
            {
                double lengthConverted = length * 0.3048;
                Console.Write(length + "f is " + lengthConverted.ToString("0.0000") + "m.");
            }
        }
    }
}
