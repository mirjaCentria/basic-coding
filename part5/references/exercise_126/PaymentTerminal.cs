namespace exercise_126
{
  public class PaymentTerminal
  {
    public double money { get; private set; }  // amount of cash
    public int coffeeAmount { get; private set; } // number of sold coffees
    public int lunchAmount { get; private set; }  // number of sold lunches

    public PaymentTerminal()
    {
      // register initially has 1000 euros of money
      this.money = 1000;
    }

    public double DrinkCoffee(double payment)
    {
      // an coffee now costs 2.50 euros
      // increase the amount of cash by the price of an coffee mean and return the change
      // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment
      double price = 2.50;
      if(payment > price) 
      {
        this.coffeeAmount++;
        this.money = this.money + price;
        return payment - price;
      }
      else return payment;      
    }

    public double EatLunch(double payment)
    {
      // a lunch now costs 10.30 euros
      // increase the amount of cash by the price of a lunch and return the change
      // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment
      double price = 10.30;
      if(payment > price) 
      {
        this.lunchAmount++;
        this.money = this.money + price;
        return payment - price;
      }
      else return payment;       
    }

    public bool DrinkCoffee(PaymentCard card)
    {
      // a coffee costs 2.50 euros
      // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
      // otherwise false is returned
      double price = 2.50;
      if(card.balance>= price)
      {
        this.coffeeAmount++;
        this.money = this.money + price;
        return card.TakeMoney(price);
      }  
      else return false;
    }

    public bool EatLunch(PaymentCard card)
    {
      // a lunch costs 10.30 euros
      // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
      // otherwise false is returned
      double price = 10.30;
      if(card.balance>= price) 
      { 
        this.lunchAmount++;
        this.money = this.money + price;
        return card.TakeMoney(price);
      }
      else return false;
    }

    public void AddMoneyToCard(PaymentCard card, double sum)
    {
      if(this.money>=sum)
      {
        card.AddMoney(sum);
        this.money = this.money + sum;
      }
    }

    public override string ToString()
    {
      return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
    }
  }
}