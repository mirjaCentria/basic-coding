<<<<<<< HEAD
<<<<<<< HEAD
=======
﻿using System;

namespace exercise_54
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
>>>>>>> 1e235ec11632bf02fa2c13ec125ac69ace35e960
﻿using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
        DivisibleByThreeInRange(-5, 20);
    }

   /** Write a method that prints all the numbers divisible by three in the given range. 
   The numbers are to be printed in order from the smallest to the greatest.*/
    public static void DivisibleByThreeInRange(int beginning, int end)
    {
      double dbl = (double)beginning;
      for(int i = beginning; i < end + 1; i++)
      {        
        if(dbl % 3 == 0) Console.WriteLine(dbl);
        dbl = dbl + 1;
      }
    }  
  }
}
<<<<<<< HEAD
=======
﻿using System;

namespace exercise_54
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
>>>>>>> d639698b175307c9b8a4dd44d945b896f41cb5e6
=======
>>>>>>> b0e4e5eb6530598e59326b1a0dffa71e0e93d10b
>>>>>>> 1e235ec11632bf02fa2c13ec125ac69ace35e960
