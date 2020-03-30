using System.Collections.Generic;

namespace Exercise
{
  public class Abbreviations
  {
     Dictionary<string, string> abbs;
      
     
    public Abbreviations()
    {
      this.abbs = new Dictionary<string, string> ();
    }

    public void AddAbbreviation(string abbreviation, string explanation)
    {
      this.abbs.Add(abbreviation, explanation);
    }

    public bool HasAbbreviation(string abbreviation)
    {
      if (this.abbs.ContainsKey(abbreviation))
      {
        return true;
      }
      return false;
    }

    public string FindExplanationFor(string abbreviation)
    {
      if(this.HasAbbreviation(abbreviation))
      {
        return this.abbs[abbreviation];
      }
      return "not found";
    }
  }
}