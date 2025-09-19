using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Costumer
    {
        int pin;
        string name;
        double balance;

        public Costumer(int pin, string name, double balance)
        {
            this.pin = pin;
            this.name = name;
            this.balance = balance;
        }

        public Costumer ActivateAccount(int pin, string name)
        {
            if(pin == this.pin && name == this.name)
            {
                Console.WriteLine("Account activated");
            }
            else
            {
                Console.WriteLine("Invalid pin or name");
            }

            return this;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance || amount < 0)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                balance -= amount;
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your balance is: {balance}");
        }
    }
}
