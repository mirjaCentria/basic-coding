namespace Exercise
{
  using System;
  using System.Collections.Generic;
  using System.Text;
  public class Hand : IComparable<Hand>
  {
    private List<Card> hand;
     public Hand()
    {
      this.hand = new List<Card>();
    }
    public void Add(Card card)
    {
      foreach(Card item in this.hand)
      {
        if(item.CompareTo(card) == 0)
        {
          goto Done;
        }
      }
      this.hand.Add(card);
      Done:;
    }

    public void Print()
    {
      StringBuilder list = new StringBuilder();
      foreach(Card item in this.hand)
      {
        System.Console.WriteLine(item);       
      }
      
    }

    public void Sort()
    {
      this.hand.Sort();
    }

    
    public int Sum()
    {
      int sum = 0;
      foreach(Card item in this.hand)
      {
        sum += item.value;
      //  sum += (int)item.suit;
      }
      return sum;
    }


    public int CompareTo(Hand hand)
    {
      if(this.Sum() > hand.Sum()) return 1;
      else if(this.Sum() < hand.Sum()) return -1;
      else return 0;
    }
  }
}