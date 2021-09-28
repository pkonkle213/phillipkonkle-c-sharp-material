namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        /// <summary>
        /// Constructor for BankAccount object. 
        /// </summary>
        /// <param name="accountHolderName">Who holds the account</param>
        /// <param name="accountNumber">What bank account is associated with the account holder</param>
        
        public BankAccount (string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
        }

        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        /// <summary>
        /// Get the Get the account holder's name.
        /// </summary>
        public string AccountHolderName { get; private set; }

        /// <summary>
        /// Get the account's number
        /// </summary>
        public string AccountNumber { get; set; }
        
        /// <summary>
        /// Get the balance of the account
        /// </summary>
        public decimal Balance { get; private set; }

        public decimal Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;
        }
    }
}
