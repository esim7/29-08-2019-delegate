using System;

namespace DelegatesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User
            {
                FullName = "Джеф Безос"
            };
            var account = new BankAccount
            {
                User = user,
            };
            //account.RegisterSender(new AccountMessageDelegate(Console.WriteLine));
            account.RegisterSender(Console.WriteLine);
            account.RegisterSender(new ConsoleSender().SendMessage);


            account.Add(200);
            account.Withdraw(100);
            account.Withdraw(200);
            Console.ReadKey();
        }
    }
}
