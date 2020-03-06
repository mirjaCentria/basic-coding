using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace exercise_136
{
  public class Person
  {
    private string name;
    private int age;

    public Person(string givenName)
    {
      this.name = givenName;
      this.age = 0;
    }

    public bool IsOfAge()
    {
      return (this.age >= 18);
    }

    public void GrowOlder()
    {
      this.age++;
    }

    public override string ToString()
    {
      return this.name;
    }
    
    public static void HowManyNames(Person person) 
    {
      string[] names = person.name.Split(" ", StringSplitOptions.RemoveEmptyEntries);
      Console.WriteLine("{0} has {1} names.", person.name, names.Length);
    }

  }
}