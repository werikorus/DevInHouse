using practice_project.Entities;
using System;


namespace practice_class_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Werik", "022.381.581-03", "920.216", "Florianópolis");

            Console.WriteLine($"Bem vindo: {client.Name}!");
        }
    }
}
