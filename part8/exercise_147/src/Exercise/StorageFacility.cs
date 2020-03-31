using System.Collections.Generic;
using System;

namespace Exercise
{
  public class StorageFacility
  {
    Dictionary<string, List<String> > units;

    public StorageFacility()
    {
      List<string> list = new List<string>();
      units = new Dictionary<string, List<string>>();
    }
    public void Add(string unit, string item)
    {
      if(units.ContainsKey(unit))
      {
        units[unit].Add(item);
      } else 
      {
        List<string> items = new List<string>();
        items.Add(item);         
        this.units.Add(unit, items);
      }
    }

    public List<string> Contents(string storageUnit)
    {
      if(units.ContainsKey(storageUnit))
        return new List<string>(units[storageUnit]);
      else return new List<string>();
    }

    public void Remove(string storageUnit, string item)
    {
      if(units.ContainsKey(storageUnit))
      {
        if(units[storageUnit].Contains(item))
        {
          units[storageUnit].Remove(item);
        }
      }
        
        
    }

    public List<string> StorageUnits()
    {
      List<string> us = new List<string>();
      foreach(KeyValuePair<string, List<string>> unit in units)
      {
        if(unit.Value.Count != 0)
          us.Add(unit.Key);
      }
      return us;
    }
  }
}