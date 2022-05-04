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
        public double cashbackAmount;
        public Memberships()
        {
            membershipID = "";
            email = "";
            membershipType = "";
            annualCost = 0.0;
            totalPurchaseAmount = 0.0;
            cashbackAmount = 0.0;
        }
        public Memberships(string newMembershipID, string newEmail, string newMembershipType, double newAnnualCost, double newTotalPurchaseAmount)
        {
            membershipID = newMembershipID;
            email = newEmail;
            membershipType = newMembershipType;
            annualCost = newAnnualCost;
            totalPurchaseAmount = newTotalPurchaseAmount;
            cashbackAmount = 0.0;
        }

        //takes our cashback amount for E and R and sets our totalPurchaseamount = to 0 
        public abstract void applyCashBack();

        public virtual void SetEmail(string newestEmail)
        {
            email = newestEmail;
        }

        public virtual void SetNewBalance(double newestBalance)
        {
            totalPurchaseAmount = totalPurchaseAmount + newestBalance;
        }
        public virtual void SetReturnBalance(double SetReturnBalance)
        {
            totalPurchaseAmount = totalPurchaseAmount - SetReturnBalance;
        }

        public override string ToString()
        {
            return ("Member ID: " + membershipID + " | email: " + email + " | Membership Type: " + membershipType + " | Annual Cost: " + annualCost + " | Current Amount: " + totalPurchaseAmount);
        }
    }
}