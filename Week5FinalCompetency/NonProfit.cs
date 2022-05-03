using System;

namespace Week5Competency
{
    class NonProfit: Memberships
    {  
        public string NPType;
        public NonProfit()
        {
            NPType = "";
        }
        public NonProfit(string newMembershipID, string newEmail, string newMembershipType, double newAnnualCost, double newTotalPurchaseAmount, string newNPType): base (newMembershipID, newEmail, newMembershipType, newAnnualCost, newTotalPurchaseAmount)
        {
            NPType = newNPType;
        }
         public override void applyCashBack()
        {
            if(NPType == "Military")
            {
            double NPcashback = .15;
            double NPDoubCashback = (NPcashback*2);
            double NPCCashbackDollar = totalPurchaseAmount * NPDoubCashback;
            totalPurchaseAmount = 0;
            Console.WriteLine("Your cashback amount is: " + NPCCashbackDollar + " dollars! Your new total purchases is:" + totalPurchaseAmount);
            }
            else
            {
                double NPcashback = .15;
                double NPCCashbackDollar = totalPurchaseAmount * NPcashback;
                totalPurchaseAmount = 0;
                Console.WriteLine("Your cashback amount is: " + NPCCashbackDollar + " dollars! Your new total purchase amount is: " + totalPurchaseAmount);
            }
        } 

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
