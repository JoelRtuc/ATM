using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Costumer
    {
        int pin, socialSecurity;
        string name;//ALWAYS USE LOWERCASE 
        decimal balance;

        public int Pin
        {
            get { return pin; }
        }

        public string Name
        {
            get { return name; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public int SocialSecurity
        {
            get { return socialSecurity; }
        }

        public Costumer()
        {
            this.pin = 0;
            this.name = "";
            this.balance = 0;
            socialSecurity = 0;
        }

        public Costumer(int pin, string name, decimal balance, int socialSecurity)
        {
            this.pin = pin;
            this.name = name;
            this.balance = balance;
            this.socialSecurity = socialSecurity;
        }

        public Costumer ActivateAccount(int pin, string name, int socialSecurity)
        {
            if(pin == Pin && name == Name && socialSecurity == SocialSecurity)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance || amount < 0)
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
            Console.WriteLine($"Your balance is: {Balance}");
        }
    }
}
