
using System;
using System.Collections.Generic;

namespace Exercise
{
  public class IOU
  {
    Dictionary<string, int> ious;      
     
    public IOU()
    {
      this.ious = new Dictionary<string, int> ();
    }
    
    public void ChangeDebt(string toWhom, int amount)
    {
      if(this.HasIOU(toWhom))
      {
      if(ious[toWhom] + amount  >= 0)
          ious[toWhom] += amount;
          else ious[toWhom] = 0;
      }
      else if(amount > 0) ious.Add(toWhom, amount);
        else ious.Add(toWhom, 0);
     // System.Console.WriteLine(toWhom + " " + ious[toWhom]);
    }

    public int HowMuchDoIOweTo(string toWhom)
    {
     // System.Console.WriteLine(toWhom + " " + ious[toWhom]);
      if(this.HasIOU(toWhom))
      {
        return ious[toWhom];
      }
      return 0;
    }

    public bool HasIOU(string toWhom)
    {
      if (this.ious.ContainsKey(toWhom))
      {
        return true;
      }
      return false;
    }




  }
}
