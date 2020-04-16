namespace Exercise
{
  using System;
  public class Dog : Animal, INoiseCapable
  {
    
    public Dog() : this("Dog")
    {
    }

    public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
      System.Console.WriteLine(base.name + " barks");
    }
    public void MakeNoise()
    {
      this.Bark();
    }
 



  }
}