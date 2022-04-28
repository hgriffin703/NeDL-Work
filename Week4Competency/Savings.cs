using System;

namespace Week4Competency
{
    class Saving: Accounts
    {
        public double annualInterestRate;
        public Saving()
        {
            annualInterestRate = 0.0;
        }
        public Saving (string newAccountID, string newAccountType, double newAccountBalance, double newAnnualInterestRate): base (newAccountID, newAccountType, newAccountBalance)
        {
            annualInterestRate = newAnnualInterestRate;
        }

        public double getInterestAmount() // interface method
        {
            return (accountBalance * annualInterestRate);
        }

            public override string ToString()
        {
            return base.ToString() + " | Annual Interest Earned:" + getInterestAmount();
        } 
    }
}