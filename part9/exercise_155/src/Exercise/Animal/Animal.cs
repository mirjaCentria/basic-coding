namespace Exercise
{
  using System;
  public abstract class Animal
  {
    public string name { get; } 
    public Animal(string name)
    {
      this.name = name;
    }

    public void Eat()
    {
      System.Console.WriteLine(this.name + " eats");
    }

    public void Sleep()
    {
      System.Console.WriteLine(this.name + " sleeps");
  
    }

  }
}