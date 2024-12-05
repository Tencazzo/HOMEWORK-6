using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6
{
    internal class metodichka
    {
        static void Main(string[] args)
        {
            ManageAccount();
            BuildInfo.Execute();
        }

        static void ManageAccount()
        {
            Console.WriteLine("Упражнение 7.1, 7.2, 7.3");
            Console.WriteLine("Банковский счет");
            BankAccount account = new BankAccount(1000, BankAccountType.Checking);
            Console.WriteLine("Номер счета: {0}", account.AccountNumber);
            Console.WriteLine("Баланс: ${0}", account.Balance);
            Console.WriteLine("Тип счета: {0}", account.AccountType);

            int userInput;
            do
            {
                Console.WriteLine("Вы хотите снять деньги (введите 1) или положить деньги (введите 2), (введите 3) для выхода");
                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Неизвестная команда! Пожалуйста, попробуйте снова.");
                    continue;
                }

                if (userInput == 1)
                {
                    PerformTransaction(account, "Снять");
                }
                else if (userInput == 2)
                {
                    PerformTransaction(account, "Положить");
                }
                else if (userInput != 3)
                {
                    Console.WriteLine("Неизвестная команда! Пожалуйста, попробуйте снова.");
                }

            } while (userInput != 3);
        }
        static void PerformTransaction(BankAccount account, string transactionType)
        {
            bool success = false;
            while (!success)
            {
                Console.WriteLine($"Какую сумму в $ вы хотите {transactionType}?");
                decimal amount;
                if (decimal.TryParse(Console.ReadLine(), out amount))
                {
                    if (transactionType == "Снять")
                    {
                        account.Withdraw(amount);
                    }
                    else
                    {
                        account.Deposit(amount);
                    }
                    Console.WriteLine("Новый баланс: ${0}", account.Balance);
                    success = true;
                }
                else
                {
                    Console.WriteLine("Это не число! Пожалуйста, попробуйте снова.");
                }
            }
        }
    }
}
