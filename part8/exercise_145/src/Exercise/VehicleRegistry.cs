using System;
using System.Collections.Generic;

namespace Exercise
{
  public class VehicleRegistry
  {
    private Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();
    public bool Add(LicensePlate licensePlate, string owner)
    {
      if(owners.ContainsKey(licensePlate))
      {
        System.Console.WriteLine("License plate already exists!");
        return false;
      }
      else
      {
        this.owners.Add(licensePlate,owner);
       // System.Console.WriteLine("License plate added!");
        return true;
      }           
    }

    public string Get(LicensePlate licensePlate)
    {
      if(owners.ContainsKey(licensePlate))
      {
        return owners[licensePlate];
      }
      else return "No such license";
    }

    public bool Remove(LicensePlate licensePlate)
    {
      if(owners.ContainsKey(licensePlate))
      {
        return owners.Remove(licensePlate);
      }
      else return false;     
    }

    public void PrintLicensePlates()
    {
      foreach(KeyValuePair<LicensePlate, string> kvp in owners)
      {
        System.Console.WriteLine(kvp.Key);
      }

    }


    public void PrintOwners()
    {
      List<string> ownerList = new List<string>();
      foreach(KeyValuePair<LicensePlate, string> kvp in owners)
      {
        if(!ownerList.Contains(kvp.Value)) ownerList.Add(kvp.Value);        
      }

      foreach(string name in ownerList)
      {
        System.Console.WriteLine(name);        
      }     

    }
  }
}