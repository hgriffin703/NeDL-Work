using System;

namespace Week5Competency
{
    class Regular: Memberships, ISpecialOffers
    {
        
        public Regular(string newMembershipID, string newEmail, string newMembershipType, double newAnnualCost, double newTotalPurchaseAmount): base (newMembershipID, newEmail, newMembershipType, newAnnualCost, newTotalPurchaseAmount)
        {
            //only uses the base class values. The cashback amount is not needed
        }
         public override void applyCashBack()
        {
            double cashbackPercent = .1;
            double cashbackAmount = cashbackPercent*totalPurchaseAmount;
            totalPurchaseAmount = 0;
            Console.WriteLine("Your cash back amount is: " + cashbackAmount + " dollars! Your new total Purchase Amount: " + totalPurchaseAmount);
        } 
        public double getSpecialOffer()
        {
            return (annualCost * .25);
        }
        public override string ToString()
        {
            return base.ToString() + " you got a special offer of 25% of your annual cost: " + getSpecialOffer();
        }
    }
}