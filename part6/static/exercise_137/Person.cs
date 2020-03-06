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

    public int HowManyNames()
    {
      string[] names = this.name.Split(" ", StringSplitOptions.RemoveEmptyEntries);
      return names.Length;
    }

    public void GrowOlder()
    {
      this.age++;
    }

    public override string ToString()
    {
      return this.name;
    }    
  }
}