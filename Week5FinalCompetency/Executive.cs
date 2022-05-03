using System;

namespace Week5Competency
{
    class Executive: Memberships, ISpecialOffers
    {
        public Executive(string newMembershipID, string newEmail, string newMembershipType, double newAnnualCost, double newTotalPurchaseAmount): base (newMembershipID, newEmail, newMembershipType, newAnnualCost, newTotalPurchaseAmount)
        {

        }
        public override void applyCashBack()
        {
            double cashbackpercent = .2;
            if(totalPurchaseAmount >= 1000)
            {
                double cashbackAmount = cashbackpercent*totalPurchaseAmount;
                totalPurchaseAmount = 0;
                Console.WriteLine("Your cashback amount is: " + cashbackAmount + " dollars! Your new total purchases is:" + totalPurchaseAmount);
            }
            else
            {
                cashbackAmount = ((cashbackpercent*totalPurchaseAmount)*2);
                totalPurchaseAmount = 0;
                Console.WriteLine("Your cashback amount is: " + cashbackAmount + " dollars! Your new total purchases is:" + totalPurchaseAmount);
            }
        }
        public double getSpecialOffer()
        {
            return (annualCost * .5);
        }
        public override string ToString()
        {
            return base.ToString() + " you also got a special offer of 50% of your annual cost: " + getSpecialOffer();
        }
    }
}