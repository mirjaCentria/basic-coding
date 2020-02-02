using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      /*Write a program, that reads an integer from the user. If the number is less than 0, it prints the number multiplied by -1. Otherwise the program prints the number itself.
       A few examples of the expected function below:*/
        int nmbr = Convert.ToInt32(Console.ReadLine());
        if(nmbr < 0) nmbr = nmbr*(-1);
        Console.WriteLine(nmbr);  
    }
  }
}
