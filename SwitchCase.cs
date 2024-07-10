/* switch case :-  /* switch statement is used for menu diven application */


using System;

class ATM
{
    static void Main()
    {
        double balance = 1000.00;  // Initial balance
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your balance is ${balance}");
                        break;
                    case 2:
                        Console.Write("Enter amount to deposit: ");
                        double deposit;
                        if (double.TryParse(Console.ReadLine(), out deposit) && deposit > 0)
                        {
                            balance += deposit;
                            Console.WriteLine($"${deposit} has been deposited. New balance is ${balance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount.");
                        }
                        break;
                    case 3:
                        Console.Write("Enter amount to withdraw: ");
                        double withdraw;
                        if (double.TryParse(Console.ReadLine(), out withdraw) && withdraw > 0 && withdraw <= balance)
                        {
                            balance -= withdraw;
                            Console.WriteLine($"${withdraw} has been withdrawn. New balance is ${balance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid withdraw amount or insufficient balance.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting the ATM. Have a nice day!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose an option (1-4).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            }
        }
    }
}
