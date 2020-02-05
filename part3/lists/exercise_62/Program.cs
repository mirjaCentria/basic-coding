<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;


namespace exercise_62
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }

        list.Add(input);
      }

      // BEGIN SOLUTION
      Console.WriteLine(list[0]);
      // END SOLUTION
    }

  }
}
=======
﻿using System;
using System.Collections.Generic;


namespace exercise_62
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }

        list.Add(input);
      }

      // BEGIN SOLUTION
      Console.WriteLine(list[0]);
      // END SOLUTION
    }

  }
}
>>>>>>> b0e4e5eb6530598e59326b1a0dffa71e0e93d10b
