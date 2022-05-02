using System;

namespace Week5Competency
{
    class Executive: Memberships
    {
        public double ExecCashback;
        public Executive()
        {
            ExecCashback = 0.0;
        }
        public Executive(string newMembershipID, string newEmail, string newMembershipType, double newAnnualCost, double newTotalPurchaseAmount, double newExecCashback): base (newMembershipID, newEmail, newMembershipType, newAnnualCost, newTotalPurchaseAmount)
        {
            ExecCashback = newExecCashback;
        }
        public override void applyCashBack(double cashBack)
        {
            cashBack = totalPurchaseAmount *ExecCashback;
        }
        public override void SetEmail(string newestEmail)
        {
            email = newestEmail;
        }

        public override string ToString()
        {
            return base.ToString() + " | Cashback Percent: " + ExecCashback;
        }
    }
}