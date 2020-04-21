namespace Exercise
{
  using System;
  using System.Text;
  
  public class Card : IComparable<Card>
  {
    public int value { get; }
    public Suit suit { get; }

    public Card(int value, Suit suit)
    {
      this.value = value;
      this.suit = suit;
    }

    public override string ToString()
    {
      StringBuilder result = new StringBuilder();
      result.Append(this.suit);
      result.Append(" ");
        
      if (this.value < 11) result.Append(this.value);
      else if(this.value == 11) result.Append("J");
      else if(this.value == 12) result.Append("Q");
      else if(this.value == 13) result.Append("K");
      else if(this.value == 14) result.Append("A");
      
      return result.ToString();
    }



    public int CompareTo(Card another)
    {
      
      if(another == null) 
      {
        return 1;
      }      

      if(this.value == another.value)
      {
        return this.suit.CompareTo(another.suit);
        //return 0;
      }

      else if(this.value > another.value)
      {
        return 1;
      }

      else return -1;
    
    }
  }
}