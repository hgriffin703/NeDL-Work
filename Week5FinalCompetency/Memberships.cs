using System;

namespace Week5Competency
{
    abstract class Memberships
    {
        public string membershipID
        {get; set;}
        public string email
        { get;set;}
        public string membershipType
        {get;set;}
        public double annualCost
        {get;set;}
        public double totalPurchaseAmount
        {get;set;}
        public Memberships()
        {
            membershipID = "";
            email = "";
            membershipType = "";
            annualCost = 0.0;
            totalPurchaseAmount = 0.0;
        }
        public Memberships(string newMembershipID, string newEmail, string newMembershipType, double newAnnualCost, double newTotalPurchaseAmount)
        {
            membershipID = newMembershipID;
            email = newEmail;
            membershipType = newMembershipType;
            annualCost = newAnnualCost;
            totalPurchaseAmount = newTotalPurchaseAmount;
        }
        //take the amount of the purchase and adds it to our running total to call in each section
        /* public double makePurchase(double purchaseAmount)
        {
            totalPurchaseAmount = totalPurchaseAmount + purchaseAmount;
        } */
        //takes our return amount and subtracts it from our running total to call in each section
/*         public double makeReturn (double returnAmount)
        {
            totalPurchaseAmount = totalPurchaseAmount - returnAmount;
        } */
        //takes our cashback amount for E and R and sets our totalPurchaseamount = to 0 
        public abstract void applyCashBack(double cashBack);
        public virtual void SetEmail(string newestEmail)
        {
            //nothing goes in here
        }

        public override string ToString()
        {
            return ("Member ID: " + membershipID + " | email: " + email + " | Membership Type: " + membershipType + " | Annual Cost: " + annualCost + " | Current Amount: " + totalPurchaseAmount);
        }
    }
}