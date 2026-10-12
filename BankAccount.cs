using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountsApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        public virtual void Deposit(decimal amount)
        {

            if (amount > 0)
            {
                Balance += amount;
                MessageBox.Show($"Your account has been successfully deposited with £{amount}. Your current balance is {Balance}.");
            }
            else
            {
                MessageBox.Show("Input invalid! Please enter an amount greater than £0.");
            }
            
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                MessageBox.Show($"Your account has been successfully withdrawn with £{amount}. Your current balance is £{Balance}.");
            }
            else
            {
                MessageBox.Show($"Input invalid! Please enter an amount greater than £0, or less than your current balance £{Balance}.");
            }
        }
    }
}
