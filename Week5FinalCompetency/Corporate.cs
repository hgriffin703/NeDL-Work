using System;

namespace Week5Competency
{
    class Corporate: Memberships
    {
        public Corporate(string newMembershipID, string newEmail, string newMembershipType, double newAnnualCost, double newTotalPurchaseAmount): base (newMembershipID, newEmail, newMembershipType, newAnnualCost, newTotalPurchaseAmount)
        {

        }
        public override void applyCashBack()
        {
            double cashbackpercent = .25;
            double cashbackdollars = cashbackpercent* totalPurchaseAmount;
            totalPurchaseAmount = 0;
            Console.WriteLine("Your cashback amount is: " + cashbackdollars + " dollars! Your new total purchase amount is: " + totalPurchaseAmount);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}