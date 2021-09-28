namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }

        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw < Balance)
            {
                base.Withdraw(amountToWithdraw);
                if(Balance < 150)
                {
                    base.Withdraw(2);
                }
            }

            return Balance;
        }
    }
}
