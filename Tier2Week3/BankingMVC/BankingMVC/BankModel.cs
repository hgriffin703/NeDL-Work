using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingMVC
{
    class BankModel
    {
        private string bankId;
        private double withdrawamount;
        private double depositamount;
        private double totalamount;

        public BankModel()
        {
            BankId = "";
            WithdrawAmount = 0;
            DepositAmount = 0;
            TotalAmount = 0;
        }
        public BankModel(string bankId, double withdrawamount, double depositamount, double totalamount)
        {
            BankId = bankId;
            WithdrawAmount = withdrawamount;
            DepositAmount = depositamount;
            TotalAmount = totalamount;
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

        public double AfterDeposit()
        {
            return TotalAmount + DepositAmount;
        }
        public double AfterWithdraw()
        {
            return TotalAmount - WithdrawAmount;
        }
    }
}
