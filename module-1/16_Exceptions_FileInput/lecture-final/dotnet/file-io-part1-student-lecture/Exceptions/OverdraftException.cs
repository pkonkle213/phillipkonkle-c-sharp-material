using System;

namespace FileInputLecture
{
    public class OverdraftException : ApplicationException
    {
        public double OverdraftAmount { get; }

        public OverdraftException(string message, double overdraftAmount)
            : base(message)
        {
            this.OverdraftAmount = overdraftAmount;
        }
    }
}
