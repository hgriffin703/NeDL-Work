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
        public override string ToString()
        {
            return ("Account ID: " + accountID + " | Account Type: " + accountType + " | Account Balance: " + accountBalance);
        }
    }
}