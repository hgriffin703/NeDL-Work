using System;

namespace Week5Competency
{
    class NonProfit: Memberships
    {
        public double NPCashback;
        public NonProfit()
        {
            NPCashback = 0.0;
        }
        public NonProfit(string newMembershipID, string newEmail, string newMembershipType, double newAnnualCost, double newTotalPurchaseAmount, double newNPCashback): base (newMembershipID, newEmail, newMembershipType, newAnnualCost, newTotalPurchaseAmount)
        {
            NPCashback = newNPCashback;
        }
         public override void applyCashBack(double cashBack)
        {
            cashBack = totalPurchaseAmount *NPCashback;
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
            return base.ToString() + " | Cashback Percent: " + NPCashback;
        }
    }
}
