namespace Exercise
{
  using System;
  public class Person
  {

    public string name { get; }
    public int age { get; }

    public Person(string name, int age)
    {
      try 
      {
        if(name =="") throw new ArgumentException(@"Name cannot be an empy string", "name");
        if(name == null) throw new ArgumentException(@"Name cannot be null", "name");
        if(name.Length > 40) throw new ArgumentException(@"Name is too long (max 40)", "name");
        if(age < 0 ) throw new ArgumentException(@"Age cannot be negative.", "age");
        if(age > 100 ) throw new ArgumentException(@"Age cannot over 120.", "age");
        this.name = name;
        this.age = age;  
      }  
      catch (ArgumentException e) 
      {
        Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);        
      }   
    }

    public override string ToString()
    {
      return this.name + " " + this.age;
    }
  }
}