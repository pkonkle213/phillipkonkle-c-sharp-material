using System;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw <= -100)
            {
                Console.WriteLine("Withdraw failed due to being above the limit. Please try again.");
            }
            else
            {
                base.Withdraw(amountToWithdraw);
                if(Balance <= 0)
                {
                    base.Withdraw(10);
                }
            }
            
            return Balance;
        }
    }
}
