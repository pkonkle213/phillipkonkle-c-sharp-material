using System;
using System.Collections.Generic;
using System.Text;

namespace FileInputLecture
{
    public class ExceptionLecture
    {
        public void Part1Cities()
        {
            /* 
            * By default, when an Exception is thrown, it will "bubble up" through the call stack until
            * it reaches the main method and then will cause the program to exit and print a stacktrace
            * to the standard output 
            * 
            * By using try/catch blocks, you can stop the Exception from exiting the method and provide
            * code to handle it. 
            */
            
            Console.WriteLine("The following cities: ");
            string[] cities = new string[] { "Cleveland", "Columbus", "Cincinatti" };

            Console.WriteLine(cities[0]);
            Console.WriteLine(cities[1]);
            Console.WriteLine(cities[2]);
            Console.WriteLine(cities[3]);  // This statement will throw an IndexOutOfRangeException
            Console.WriteLine("are all in Ohio."); // This line won't execute because the previous statement throws an Exception

            Console.WriteLine();
        }

        public void Part2OvertimeHours()
        {
            /*
             * The exceptions we typically care about are things that we can't control. For example, data in files or a database,
             * network communication issues, or invalid user input.
             * 
             * Let's examine invalid user input here.
             */
            Console.WriteLine("The standard work week is 40 hours.");
            Console.WriteLine("How many hours did you work this week? >>> ");
            string hoursString = Console.ReadLine();

            int hoursWorked = int.Parse(hoursString);
            int overtimeHours = hoursWorked - 40;
            Console.WriteLine($"You worked {overtimeHours} hours of overtime.");

            Console.WriteLine();
        }

        public void Part3CallStack()
        {
            /* 
            * try/catch blocks will also catch Exceptions that are 
            * thrown from method calls further down the stack.
            * 
            * Let's try calling examples.DoSomethingDangerous
            */
            Console.WriteLine("Press any key when you're ready for something dangerous!");
            Console.ReadLine();

            ExceptionExamples examples = new ExceptionExamples();
            examples.PerformDivision(42, 0); // Will cause a DivisionByZeroException inside of the PerformDivision method

            Console.WriteLine();
        }

        public void Part4ThrowingExceptions()
        {
            /* 
            * we can throw our own Exceptions in response to exceptional cases 
		    * see the source code of calculateHotelRoomCharges for an example 
            */
            ExceptionExamples examples = new ExceptionExamples();

            int nights = -3;
            int numberOfGuests = 2;
            try
            {
                double amountOwed = examples.CalculateHotelRoomCharges(nights, numberOfGuests);
                Console.WriteLine("Total owed for " + numberOfGuests + " guests for " + nights + " nights is $" + amountOwed);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(numberOfGuests + " guests for " + nights + " nights just doesn't make sense.");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }

        public void Part5Finally()
        {
            /*
            * We can also create our own Exceptions to use if the System provided
            * exceptions don't give us what we need.  
            * 
            * The "finally" block means that if an exception is caught or not, the code 
            * in the finally block should run last.          
            */
            ExceptionExamples examples = new ExceptionExamples();

            Console.WriteLine("How much would you like to withdraw from your account? Your balance is $5000.00");
            string withdrawString = Console.ReadLine();

            try
            {
                double withdrawAmount = double.Parse(withdrawString);
                double finalBalance = examples.Withdraw(withdrawAmount);
                Console.WriteLine("The final balance is " + finalBalance);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("That's not a valid amount to withdraw");
                Console.WriteLine(ex.Message);
            }
            catch (OverdraftException ex)
            {
                Console.WriteLine("An overdraft exception was caught");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("An argument out of range exception was caught");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for banking with Fly By Night Banking.");
                Console.WriteLine("We're not sure why you trust us with your money, but we're glad you do!");
            }

            Console.WriteLine();
        }
    }
}
