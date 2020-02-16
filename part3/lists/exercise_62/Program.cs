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
>>>>>>> d639698b175307c9b8a4dd44d945b896f41cb5e6
