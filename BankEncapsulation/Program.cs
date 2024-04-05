namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            Console.WriteLine("How much do you want to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            account1.Deposit(amountToDeposit);
            double userBalance = account1.GetBalance();

            Console.WriteLine($"Your account balance is: ${userBalance}");


            BankAccount account = new BankAccount(); 
            int enteredPin;
            Console.WriteLine("Welcome to the Bank!");

           // Authenticate user with PIN
            do
            {
                Console.Write("Please enter your PIN: ");
                enteredPin = int.Parse(Console.ReadLine());

                if (!account.ValidatePin(enteredPin))
                {
                    Console.WriteLine("Invalid PIN. Please try again.");
                }
            } while (!account.ValidatePin(enteredPin));

            Console.WriteLine("Authentication successful.");

            while (true)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            account.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;
                    case 2:
                        Console.Write("Enter the amount to withdraw: ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            account.Withdraw(withdrawAmount); 
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Your balance is: ${account.GetBalance()}");
                        break;
                    case 4:
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();


            }
        }
    }
}