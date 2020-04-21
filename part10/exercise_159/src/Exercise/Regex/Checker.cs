namespace Exercise
{
  using System;
  using System.Text.RegularExpressions;
  public class Checker
  {
    public bool DayOfWeek(string str)
    {
      Regex regex = new Regex("^mon|tue|wed|thu|fri|sat|sun$"); 

      if(str.Length != 3) return false;
      if (regex.IsMatch(str))
      {
        return true;
      }
      else
      {
        return false;
      }
      
    }

    public bool AllVowels(string str)
    {
      Regex regex = new Regex("^[aeiuo]+$");

      if (regex.IsMatch(str))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool TimeOfDay(string str)
    { 
      Regex rgx = new Regex("^([0-2][0-3]|[0-1][0-9]):[0-5][0-9]:[0-5][0-9]+$?");
      if (rgx.IsMatch(str))
      {
        return true;
      }
      else return false;
    }
  }
}