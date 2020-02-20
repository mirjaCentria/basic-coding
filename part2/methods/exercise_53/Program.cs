﻿using System;
using System.Globalization;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      Division(2, 3);
    }

    public static void Division(int numerator, int denominator)
    {
      NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;
      double result = (double)numerator/denominator;     
      Console.WriteLine( result.ToString( "0.##", nfi ) );
    }
  }
}

