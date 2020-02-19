using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE! 
      // Do your code here!
      Account munAccount = new Account("mun tili", 100.00);
      munAccount.Deposit(20.0);
      Console.WriteLine(munAccount.balance);
    }
  }
}



