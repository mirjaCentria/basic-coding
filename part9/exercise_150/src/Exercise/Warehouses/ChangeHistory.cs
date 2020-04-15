namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class ChangeHistory
  {
    private List<int> history;

    public ChangeHistory()
    {
        this.history = new List<int>();
    }

    public void Add(int status)
    {
      this.history.Add(status);
    }

    public void Clear()
    {
      this.history.Clear();
    }

    public int MaxValue()
    {
      int max = 0;
      foreach(int item in history)
      {
        if(item > max) max = item;
      }
      return max;
    }

    public int MinValue()
    {
      int min = 2147483647;

      foreach(int item in history)
      {
        if(item < min) min = item;
      }
      return min;
  
    }

    public override string ToString()
    {
      int current = history.Count - 1;
      return "Current: " + history[current] 
              + " Min: " + this.MinValue() 
              + " Max: " + this.MaxValue();
    }
  }
}
