using System;

namespace Week4Competency
{
    class CD: Accounts, IGetInterestRate
    {
        public double annualInterestRate2;
        public int withdrawalFee;
        public CD()
        {
            annualInterestRate2 = 0.0;
            withdrawalFee = 0;
        }
        public CD(string newAccountID, string newAccountType, double newAccountBalance, double newAnnualInterestRate2, int newWithdrawalFee): base (newAccountID, newAccountType, newAccountBalance)
        {
            annualInterestRate2 = newAnnualInterestRate2;
            withdrawalFee = newWithdrawalFee;
        }
        public double getInterestAmount() // interface method
        {
            return (accountBalance * annualInterestRate2);
        }

        public override int GetEarlyFee()
        {
            return withdrawalFee; //sets the GetEarlyFee equal to the withdrawalfee for the accounts page
        }
        public override void getWithdrawal(double makeWithdrawal)
        {
            accountBalance = accountBalance - makeWithdrawal - withdrawalFee;
        }

        public override string ToString()
        {
            return base.ToString() + " | Annual Interest Rate: " + annualInterestRate2 + " | Annual Interest Earned: " + getInterestAmount() + " | Early Withdrawal Fee: " + withdrawalFee;
        }
    }
}