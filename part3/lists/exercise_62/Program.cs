<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
=======
﻿﻿using System;
>>>>>>> 1e235ec11632bf02fa2c13ec125ac69ace35e960
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
      Console.WriteLine(list[2]);
      // END SOLUTION
    }

  }
}
<<<<<<< HEAD
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
=======
>>>>>>> 1e235ec11632bf02fa2c13ec125ac69ace35e960
