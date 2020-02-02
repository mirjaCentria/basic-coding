using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
      /** Implement a program that asks the user for numbers
      (the program first prints "Write numbers: ") until the 
      user gives the number -1, When the user writes -1, 
      the program prints "Thx! Bye!" and ends.
      
      * Extend the program so, that it prints the sum of the 
      numbers (not including the -1) the user has written.
      
      * Extend the program so, that it also prints the number 
      of numbers (not including the -1) the user has written.
      
      * Extend the program so, that it prints the mean of 
      numbers (not including the -1) the user has written.
      
      * Extend the program so that it prints the number of
       even and odd numbers (excluding the -1).
      
      Even: 2 Odd: 1
      */
      
        string prompt = "Give numbers:";
        string thank = "Thx! Bye!";
        string sSum = "Sum: ";
        string sCount = "Numbers: ";
        string sAverage = "Average: ";
        string sEven = "Even: ";
        string sOdd = "Odd: ";
        int nmbr = 0;
        int sum = 0;
        int cnt = 0;    
        int cEven = 0;
        int cOdd = 0;   
        double dAvg = 0; 
      
        Console.WriteLine(prompt);
        nmbr = Convert.ToInt32(Console.ReadLine()); 

        while (nmbr != -1)
        {
          sum = sum + nmbr;    
          cnt++;      
          if(nmbr % 2 == 0) cEven++;
            else cOdd++;
          nmbr = Convert.ToInt32(Console.ReadLine());          
        } 
        dAvg = (double)sum/cnt;
        Console.WriteLine(thank);    
        Console.WriteLine(sSum + sum);  
        Console.WriteLine(sCount + cnt);  
        Console.WriteLine(sAverage + dAvg);  
        Console.WriteLine(sEven + cEven);  
        Console.WriteLine(sOdd + cOdd); 

    }
  }
}
