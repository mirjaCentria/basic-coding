namespace Exercise
{
  using System;
  using System.Collections.Generic;

  public class LotteryRow
  {
    private List<int> numbers;
    private Random rmizer;

    public LotteryRow()
    {      
      this.RandomizeNumbers();
    }

    public List<int> Numbers()
    {
      return this.numbers;
    }

    public bool ContainsNumber(int number)
    {
      // Tests whether the number is already among the randomized numbers
      foreach(int item in this.numbers)
      {
        if(item == number) return true;
      }
      return false;
    }

    public void RandomizeNumbers()
    {
      // initialize the list for numbers
      this.numbers = new List<int>();
      // Implement the randomization of the numbers by using the method ContainsNumber() here
      this.rmizer = new Random();
      int number = 0;

      while(this.numbers.Count < 7)
      {
        number = rmizer.Next(1,40);
        if(!this.ContainsNumber(number)) numbers.Add(number);
      }
      numbers.Sort();      
    }

  }
}