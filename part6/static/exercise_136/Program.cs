﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace exercise_136
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Person ada = new Person("Ada Lovelace");
      Person jack = new Person("Jack The Ripper");
      Person mike = new Person("Mike The Incredible Magic Mouse");

      Person.HowManyNames(ada);    
      Person.HowManyNames(jack);
      Person.HowManyNames(mike);
    }
        //split @" +"
    // Do something here
  }
}