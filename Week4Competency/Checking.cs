using System;

namespace Week4Competency
{
    class Checking: Accounts
    {
        public int annualFee;
        public Checking()
        {
            annualFee = 0;
        }
        public Checking(string newAccountID, string newAccountType, double newAccountBalance, int newAnnualFee): base(newAccountID, newAccountType, newAccountBalance)
        {
            annualFee = newAnnualFee;
        }
        public override string ToString()
        {
            return base.ToString() + " | Annual Fee: " + annualFee; 
        }
    }
}