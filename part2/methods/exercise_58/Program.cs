<<<<<<< HEAD
﻿using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    // Write your method here:
    
  }
}
=======
﻿using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

  
     public static int Smallest(int number1, int number2)
    {
      if(number1 > number2) return number2;
      else return number1;
    }
    
  }
}
>>>>>>> b0e4e5eb6530598e59326b1a0dffa71e0e93d10b
