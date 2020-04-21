namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      Card first = new Card(2, Suit.Club);
      Card second = new Card(14, Suit.Spade);
      Card third = new Card(12, Suit.Heart);
      Card fourth = new Card(14, Suit.Heart);
      Card fifth = new Card(12, Suit.Diamond);

      List<Card> list = new List<Card> { first, second, third, fourth, fifth };
      list.Sort();
     // list.ForEach(Console.WriteLine);

      Hand hand = new Hand();

      hand.Add(new Card(2, Suit.Diamond));
      hand.Add(new Card(14, Suit.Spade));
      hand.Add(new Card(12, Suit.Heart));
      hand.Add(new Card(2, Suit.Spade));
      System.Console.WriteLine(hand.Sum());
      
      hand.Print();
       System.Console.WriteLine();
      hand.Sort();
      hand.Print();
    }
  }
}
