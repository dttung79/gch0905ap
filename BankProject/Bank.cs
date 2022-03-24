using System;
using System.Collections.Generic;

namespace BankProject
{
    public class Bank
    {
        private string name;
        private List<BankAccount> accounts;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Bank(string name)
        {
            Name = name;
            accounts = new List<BankAccount>();
        }

        public void AddAccount(BankAccount acc) 
        {
            accounts.Add(acc);
        }

        public BankAccount FindAcount(int id)
        {
            foreach (BankAccount acc in accounts)
            {
                if (acc.ID == id) return acc;
            }

            return null;
        }

        public void Withdraw(int id, string pin, double amount)
        {
            BankAccount acc = FindAcount(id);
            if (acc == null) System.Console.WriteLine("Account not found");
            else if (acc.PIN != pin) System.Console.WriteLine("Incorrect PIN");
            else acc.Withdraw(amount);
        }
        public void Deposit(int id, string pin, double amount)
        {
            BankAccount acc = FindAcount(id);
            if (acc == null) System.Console.WriteLine("Account not found");
            else if (acc.PIN != pin) System.Console.WriteLine("Incorrect PIN");
            else acc.Deposit(amount);
        }
        public void ShowAccount(int id)
        {
            BankAccount acc = FindAcount(id);
            if (acc == null) System.Console.WriteLine("Account not found");
            else acc.ShowInfo();
        }
    }
}