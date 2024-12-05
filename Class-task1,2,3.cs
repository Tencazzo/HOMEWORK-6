using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6
{
    enum BankAccountType
    {
        Savings,
        Checking,
        Deposit
    }
    internal class BankAccount
    {
        private static int accountNumberCounter = 0001;
        private int accountNumber;
        private decimal balance;
        private BankAccountType accountType;

        public BankAccount(decimal initialBalance, BankAccountType type)
        {
            GenerateAccountNumber();
            balance = initialBalance;
            accountType = type;
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public BankAccountType AccountType
        {
            get { return accountType; }
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine("Успешно снято ${0} с номера счета {1}.", amount, accountNumber);
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете номер {0}.", accountNumber);
            }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine("Успешно внесено ${0} на счет номер {1}.", amount, accountNumber);
        }


        private void GenerateAccountNumber()
        {
            accountNumber = accountNumberCounter++;
        }

    }
}
