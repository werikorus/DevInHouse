using System;
using System.Collections.Generic;
using System.Text;

namespace practice_project.Entities
{
    public class SavingAccount: BankAccount
    {
        public decimal SavingIncomePercentage { get; private set; }

        public SavingAccount(Client client): base(client)
        {
            SavingIncomePercentage = 0.04M;
        }
    }
}
