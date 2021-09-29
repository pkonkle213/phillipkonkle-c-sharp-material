using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer : IAccountable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                decimal totalBalance = 0;
                foreach(IAccountable account in allBankAccounts)
                {
                    totalBalance += account.Balance;
                }

                if (totalBalance >= 25000)
                {
                    return true;
                }
                return false;
            }
        }

        public int Balance { get; }

        List<IAccountable> allBankAccounts = new List<IAccountable>();

        public void AddAccount(IAccountable newAccount)
        {
            allBankAccounts.Add(newAccount);
        }

        public IAccountable[] GetAccounts()
        {
            return allBankAccounts.ToArray();
        }

    }
}
