﻿using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      PrintFromNumberToOne(5);
    }

    public static void PrintFromNumberToOne(int number)
    {
      while(number > 0)
      { 
        Console.WriteLine(number);
        number--;
      }
    }

  }
}


