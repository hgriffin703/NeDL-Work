using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingMVC
{
    class BankView
    {
        private string bankId;
        private double withdrawamount;
        private double depositamount;
        private double totalamount;

        public bankView()
        {
            BankId = "";
            WithdrawAmount = 0;
            DepositAmount = 0;
            TotalAmount = 0;
            GetValues();
        }
        public string BankId
        {
            get { return bankId; }
            set { bankId = value; }
        }
        public double WithdrawAmount
        {
            get { return withdrawamount; }
            set { withdrawamount = value; }
        }
        public double DepositAmount
        {
            get { return depositamount; }
            set { depositamount = value; }
        }
        public double TotalAmount
        {
            get { return totalamount; }
            set { totalamount = value; }
        }
        private void GetAccount()
        {
            Console.WriteLine("What is your account number");
            string accountnumber = Console.ReadLine();
        }
        private void GetValues()
        {
            Console.WriteLine("What is the amount you want to withdraw or deposit?");
            double BankAmount = Convert.ToDouble(Console.ReadLine());
        }
        public void GetAmounts()
        {
            Console.WriteLine("Would you like to D: Deposit or W: Withdraw");
            char selection = Convert.ToChar(Console.ReadLine());

            if(selection == 'D' || selection == 'd')
            {
                Console.WriteLine("Your account total is: {0} " + DepositAmount);
            }
            if(selection == 'W' || selection== 'd')
            {
                Console.WriteLine("Your account total is: {0} " + WithdrawAmount);
            }
        }
    }
}