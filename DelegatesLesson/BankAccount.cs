using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesLesson
{
    // код_доступа delegate возвращаемый_тип имя (параметры);
    public delegate void AccountMessageDelegate(string message);

    public class BankAccount : Entity
    {
        private AccountMessageDelegate MessageDelegate;

        public User User { get; set; }
        public int Balance { get; private set; }

        public void RegisterSender(AccountMessageDelegate messageDelegate)
        {
            //Delegate.Combine(this.MessageDelegate, messageDelegate);
            this.MessageDelegate += messageDelegate;
        }

        public void UnregisterSender(AccountMessageDelegate messageDelegate)
        {
            //Delegate.Remove(this.MessageDelegate, messageDelegate)
            this.MessageDelegate -= messageDelegate;
        }

        public void Add(int sum)
        {
            Balance += sum;
            MessageDelegate?.Invoke($"Успешно пополнено на {sum}. Баланс {Balance}");
            //Sender.SendMessage($"Успешно пополнено на {sum}. Баланс {Balance}");
        }
        public void Withdraw(int sum)
        {
            if(Balance < sum)
            {
                MessageDelegate?.Invoke($"Невозможно снять {sum}. Баланс {Balance}");
                return;
            }
            Balance -= sum;
            MessageDelegate?.Invoke($"Успешно снято со счета на {sum}. Баланс {Balance}");

        }
    }
}
