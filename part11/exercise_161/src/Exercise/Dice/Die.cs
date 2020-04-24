namespace Exercise
{
  using System;
  public class Die
  {
    private Random rndom;
    private int numberOfFaces;

    public Die(int numberOfFaces)
    {
      this.rndom = new Random();
      this.numberOfFaces = numberOfFaces;
      // Initialize the value of numberOfFaces here
    }
    public int ThrowDie()
    {
       // generate a random number which may be any number
      // between one and the number of faces, and then return it
      return  this.rndom.Next(1,this.numberOfFaces);
    }
  }
}