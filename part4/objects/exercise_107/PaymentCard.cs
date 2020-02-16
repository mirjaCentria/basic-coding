using System;

namespace exercise_107 
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

    public void EatLunch()
    {
      double lunch = 10.60;
      this.balance = this.balance - lunch;
    }

    public void DrinkCoffee()
    {
      double coffee = 2.0;
      this.balance = this.balance - coffee;
    }


  }
}