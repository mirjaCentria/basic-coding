using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
      // Call your method here:
 
    }

    // Write your method here:
    public static void PrintPhrase() {

=======
>>>>>>> 1e235ec11632bf02fa2c13ec125ac69ace35e960
      Console.WriteLine("How many times?");
      int nmbr = Convert.ToInt32(Console.ReadLine());
      for(int i = 0; i < nmbr; i++)
      {
        PrintPhrase();
      }  
    }

    public static void PrintPhrase() {
      string testLine = "In a hole in the ground there lived a method";
      Console.WriteLine(testLine);
<<<<<<< HEAD
=======
      // Call your method here:
 
    }

    // Write your method here:
    public static void PrintPhrase() {

>>>>>>> d639698b175307c9b8a4dd44d945b896f41cb5e6
=======
>>>>>>> b0e4e5eb6530598e59326b1a0dffa71e0e93d10b
>>>>>>> 1e235ec11632bf02fa2c13ec125ac69ace35e960
    }
  }
}
