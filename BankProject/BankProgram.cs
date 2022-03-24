using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject
{
    public class BankProgram
    {
        private Bank bank;

        public BankProgram()
        {
            System.Console.Write("Enter bank name: ");
            string name = Console.ReadLine();
            bank = new Bank(name);
        }

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) break;
            }
        }

        private void PrintMenu()
        {
            System.Console.WriteLine(bank.Name + " BANK Manager");
            System.Console.WriteLine("1. Add account.");
            System.Console.WriteLine("2. Withdraw.");
            System.Console.WriteLine("3. Deposit.");
            System.Console.WriteLine("4. Show account.");
        }

        private int GetChoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddAccount(); break;
                case 2: Withdraw(); break;
                case 3: Deposit(); break;
                case 4: ShowAccount(); break;
            }
        }
        private void AddAccount()
        {
            System.Console.Write("Enter account PIN: ");
            string pin = Console.ReadLine();
            System.Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            BankAccount acc = new BankAccount(pin, balance);
            bank.AddAccount(acc);
            acc.ShowInfo();
        }

        private void Withdraw()
        {
            // enter id, pin, amount
            System.Console.Write("Enter account id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter account PIN: ");
            string pin = Console.ReadLine();
            System.Console.Write("Enter amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            // call Withdraw of bank            
            bank.Withdraw(id, pin, amount);
            bank.ShowAccount(id);
        }

        private void Deposit()
        {
            // enter id, pin, amount
            System.Console.Write("Enter account id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter account PIN: ");
            string pin = Console.ReadLine();
            System.Console.Write("Enter amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            // call Withdraw of bank            
            bank.Deposit(id, pin, amount);
            bank.ShowAccount(id);
        }

        private void ShowAccount()
        {
            System.Console.Write("Enter account id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            bank.ShowAccount(id);
        }
    }
}