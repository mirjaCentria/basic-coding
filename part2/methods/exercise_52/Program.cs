<<<<<<< HEAD
﻿using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:

    }

    // Write your method here:

  }
}
=======
﻿using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      PrintFromNumberToOne(5);

    }

    /** Create the following method in the exercise template:
     **public static void PrintFromNumberToOne(int number)**. 
     It should print the numbers from the number passed as a parameter
      down to one. Two examples of the method's usage are given below.   
    */
    public static void PrintFromNumberToOne(int number)
    {
      while(number > 0)
      { 
        Console.WriteLine(number);
        number--;
      }
    }

  }
}
>>>>>>> b0e4e5eb6530598e59326b1a0dffa71e0e93d10b
