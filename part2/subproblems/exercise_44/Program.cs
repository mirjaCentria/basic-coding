using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {
      /*Write a program that reads two integers from the user input.
      If the first number is greater than the second, the program prints 
      "(first) is greater than (second)." If the first number is less than the second, the program prints "(first) is less than (second)." Otherwise the program prints "(first) is equal to (second)." The (first) and (second) should always be replaced 
      with the actual numbers given by the user.*/

        string lrg = " is greater than ";
        string sml = " is less than ";
        string eq = " is equal to ";
        int nmbr1 = Convert.ToInt32(Console.ReadLine());
        int nmbr2 = Convert.ToInt32(Console.ReadLine());
        if(nmbr1 > nmbr2) Console.WriteLine(nmbr1+ lrg + nmbr2 + ".");
        else if(nmbr1 < nmbr2) Console.WriteLine(nmbr1 + sml + nmbr2 + ".");
        else if(nmbr1 == nmbr2) Console.WriteLine(nmbr1 + eq + nmbr2 + ".");

    }
  }
}
