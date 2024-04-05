using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		private double balance = 0;
		private int pin = 1234;

		public void Deposit(double amount)
		{
			balance = balance + amount;
			Console.WriteLine($"Deposited {amount} into the account.");

		}
		public double GetBalance()
		{
			return balance;
		}
		
        public void Deposit()
		{
			
		}
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Withdrawn {amount} from the account.");
        }

        public bool ValidatePin(int enteredPin)
        {
            return pin == enteredPin;
        }
    }


}

