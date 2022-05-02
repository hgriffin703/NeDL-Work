using System;

namespace Week5Competency
{
    class Corporate: Memberships
    {
        public double corpCashback;
        public Corporate()
        {
            corpCashback = 0.0;
        }
        public Corporate(string newMembershipID, string newEmail, string newMembershipType, double newAnnualCost, double newTotalPurchaseAmount, double newCorpCashback): base (newMembershipID, newEmail, newMembershipType, newAnnualCost, newTotalPurchaseAmount)
        {
            corpCashback = newCorpCashback;
        }
        public override void applyCashBack(double cashBack)
        {
            cashBack = totalPurchaseAmount *corpCashback;
        }

        public override string ToString()
        {
            return base.ToString() + " | Cashback Percent: " + corpCashback;
        }
    }
}