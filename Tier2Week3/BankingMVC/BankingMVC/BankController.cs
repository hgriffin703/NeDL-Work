using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingMVC
{
    class BankController
    {
        private BankModel bankModel;
        private BankView bankView;

        public BankController()
        {
            bankView = new BankView();
            bankModel = new BankModel(bankView.BankId, bankView.WithdrawAmount, bankView.DepositAmount, bankView.TotalAmount);
            bankView.WithdrawAmount = bankModel.WithdrawAmount();
            bankView.DepositAmount = bankModel.DepositAmount();
            bankView.GetAmounts();
        }
    }
}