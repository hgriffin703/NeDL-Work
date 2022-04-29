using System;
namespace Week4Competency
{
    abstract class Accounts
    {
        public string accountID;
        public string accountType;
        public double accountBalance;

        public Accounts()
        {
            accountID = "";
            accountType = "";
            accountBalance = 0.0;
        }
        public Accounts (string newAccountID, string newAccountType, double newAccountBalance)
        {
            accountID = newAccountID;
            accountType = newAccountType;
            accountBalance = newAccountBalance;
        }

//this method takes the depositAmount and updates the account balance with that amount
        public void makeDeposit(double depositAmount)
        {
           accountBalance= accountBalance + depositAmount;
        }

        //create an abstract to get the withdrawal amount
        public abstract void getWithdrawal(double makeWithdrawal);
        //creates a dummy option here to call on the Hourly page for getting the array to be able to read the salary
        public virtual int GetEarlyFee()
            {
              return -1;
            }

        public override string ToString()
        {
            return ("Account ID: " + accountID + " | Account Type: " + accountType + " | Account Balance: " + accountBalance);
        }
    }
}