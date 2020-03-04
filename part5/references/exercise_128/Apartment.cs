namespace exercise_128
{

  using System;
  public class Apartment
  {

    private int rooms;
    private int squares;
    private int pricePerSquare;

    public Apartment(int rooms, int squares, int pricePerSquare)
    {
      this.rooms = rooms;
      this.squares = squares;
      this.pricePerSquare = pricePerSquare;
    }

    public bool LargerThan(Apartment compared)
    { 
      // weird
      if(this.squares > compared.squares) return true;
      else return false;
    }

    private int Price()
    {
      return this.princePerSquare*this.squares;
    }

    public int PriceDifference(Apartment compared)
    {
      // Math.Abs returns the absolute value
      return Math.Abs(this.Price() - compared.Price());
    }

    public bool MoreExpensiveThan(Apartment compared)
    {
      if(this.Price() > compared.Price()) return true;
      else return false;
    }

    
    public override string ToString()
    {
      return " rooms " + this.rooms.ToString() + " price " +  (this.squares*this.princePerSquare).ToString() 
      + " squares " + this.squares.ToString() + " price/square " + this.princePerSquare.ToString();
    }
  }

}
