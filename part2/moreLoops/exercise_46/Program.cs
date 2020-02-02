using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {
      /** Write a program, which reads an integer from the user. 
      Then the program prints numbers from that number to 100.
       You can assume that the user always gives a number 
       less than 100.*/ 
       
        int max = 100;
        int nmbr = Convert.ToInt32(Console.ReadLine());
        while (nmbr < max + 1)
        {            
            Console.WriteLine(nmbr++);
        } 

    }
  }
}
