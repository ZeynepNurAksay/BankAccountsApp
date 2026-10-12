using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountsApp
{
    internal class SavingsAccount: BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate):base(owner)
        {
            InterestRate = interestRate;
        }

        public override void Deposit(decimal amount)
        {

            if (amount > 0)
            {
                decimal interestAmount = amount * (InterestRate / 100);
                Balance += amount + interestAmount;
                MessageBox.Show($"Your account has been successfully deposited with £{amount} + £{interestAmount} interest amount. Your current balance is {Balance}.");
            }
            else
            {
                MessageBox.Show("Input invalid! Please enter an amount greater than £0.");
            }

        }
    }
}
