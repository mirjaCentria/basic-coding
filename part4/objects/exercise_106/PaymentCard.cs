using System;

namespace exercise_106 
{  public class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      this.balance = openingBalance;
    }

    public override string ToString()
    {
        string line = "The card has a balance of " + this.balance + " euros";
        return line;
    }
  }
}