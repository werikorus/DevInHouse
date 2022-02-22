using System;

namespace practice_project.Entities
{
    public class CheckingAccount:  BankAccount
    {
        public decimal Limit { get; private set; }
        public decimal CheckingAccountMaintenance { get; private set; }

        public CheckingAccount(Client client, decimal limit): base(client)
        {
            CheckingAccountMaintenance = 0.08M;
            Limit = limit;
        }

    }
}
