﻿using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

              string sLine = "How many days?";
        int iDays = 0;
        int seconds = 0;
       
        Console.WriteLine(sLine);
        iDays = int.Parse(Console.ReadLine());

        seconds = iDays*86400; //24 h x 60 min x 60 s

        Console.WriteLine(seconds);
    }
  }
}
