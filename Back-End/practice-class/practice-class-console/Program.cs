using practice_project.Entities;
using System;


namespace practice_class_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client("Werik", "022.381.581-03", "920.216", "Florianópolis");
            BankAccount bacc = new BankAccount(c1);

            Console.WriteLine($"Bem vindo: {c1.Name}! Sua conta é : {bacc}");
        }
    }
}
