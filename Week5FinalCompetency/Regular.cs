using System;

namespace Week5Competency
{
    class Regular: Memberships
    {
        public double cashback;
        public Regular()
        {
            cashback = 0.0;
        }
        public Regular(string newMembershipID, string newEmail, string newMembershipType, double newAnnualCost, double newTotalPurchaseAmount, double newCashback): base (newMembershipID, newEmail, newMembershipType, newAnnualCost, newTotalPurchaseAmount)
        {
            cashback = newCashback;
        }
         public override void applyCashBack(double cashBack)
        {
            cashBack = totalPurchaseAmount *cashback;
        } 
        public override void SetEmail(string newestEmail)
        {
            email = newestEmail;
        }
        public override void SetNewBalance(double newestBalance)
        {
            totalPurchaseAmount = totalPurchaseAmount + newestBalance;
        }
        public override string ToString()
        {
            return base.ToString() + " | Cashback Percent: " + cashback;
        }
    }
}