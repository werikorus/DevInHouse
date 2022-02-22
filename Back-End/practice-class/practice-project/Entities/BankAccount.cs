using System;
using practice_project.Entities.Enums;

namespace practice_project.Entities
{
    public class BankAccount
    {
        public int AccountNumber { get; private set; }
        public int VerifyinDigit { get; private set; }

        public decimal Balance { get; private set; }
        public DateTime? AccountCreated { get; private set; }

        public DateTime? AccountFinished { get; private set; }

        public AccountSituationEnum AccountSituation { get; set; }


        public string Password { get; private set; }

        public Client Client { get; private set; }

        public BankAccount(Client client)
        {
            Random random = new Random();
            AccountNumber = random.Next(50000,100000);
            VerifyinDigit = random.Next(0, 9);
            AccountSituation = AccountSituationEnum.Created;
            Client = client;
        }


    }
}
