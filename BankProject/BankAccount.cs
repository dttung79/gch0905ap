using System;

namespace BankProject
{
    public class BankAccount
    {
        private int id; // instance attribute (belongs to object)
        private static int count = 0;  // class attribute (belongs to class not object)

        private string pin; // instance attribute
        private double balance; // instance attribute

        // properties
        public int ID 
        {
            get { return id; }
        }
        
        public string PIN 
        {
            get { return pin; }
            set { pin = value; } // should validate
        }

        public double Balance 
        {
            get { return balance; }
        }

        public BankAccount()
        {
            id = count++; // id = count; count++;
            pin = "1234";
            balance = 0.0;
        }

        public BankAccount(string pin, double balance)
        {
            id = count++;
            PIN = pin; // this.pin = pin;
            this.balance = 0;
            Deposit(balance);
        }


        public void Withdraw(double amount)
        {
            if (amount > balance) System.Console.WriteLine("Not enough balance!");
            else if (amount <= 0) System.Console.WriteLine("Invalid amount!");
            else balance -= amount;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0) System.Console.WriteLine("Invalid amount!");
            else balance += amount;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("Bank ID: " + id);
            System.Console.WriteLine("Bank balance: " + balance);
            //System.Console.WriteLine("Count: " + count);
        }
    }
}