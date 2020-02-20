using System;

namespace exercise_126
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Try your code here, if you want
      PaymentCard munCard = new PaymentCard(10);
      Console.WriteLine(munCard.ToString());
      bool result = munCard.TakeMoney(8);
      Console.WriteLine("succesfully withdrew: " + result.ToString());
      Console.WriteLine(munCard.ToString());
      result = munCard.TakeMoney(8);
      Console.WriteLine("succesfully withdrew: " + result.ToString());
      Console.WriteLine(munCard.ToString());


        PaymentTerminal lunchCafeteria = new PaymentTerminal();
        Console.WriteLine(lunchCafeteria);

        PaymentCard annesCard = new PaymentCard(2);

        Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

        bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
        Console.WriteLine("there was enough money: " + wasSuccessful);

        lunchCafeteria.AddMoneyToCard(annesCard, 100);

        wasSuccessful = lunchCafeteria.EatLunch(annesCard);
        Console.WriteLine("there was enough money: " + wasSuccessful);

        Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

        Console.WriteLine(lunchCafeteria);
    }
  }
}
