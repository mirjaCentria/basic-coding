  namespace Exercise
{
  public class LicensePlate
  {
    public string liNumber { get; }
    private string country;

    public LicensePlate(string country, string liNumber)
    {
      this.liNumber = liNumber;
      this.country = country;
    }

    public override string ToString()
    {
      return country + " " + liNumber;
    }

    public override bool Equals(object compared)
    {
      if((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }
      
      LicensePlate lp = (LicensePlate)compared;
                
      if (!this.liNumber.Equals(lp.liNumber))
      {
        return false;
      }
      if (!this.country.Equals(lp.country))
      {
        return false;
      }  
      return true;
    }

    public override int GetHashCode()
    {
      return this.liNumber.GetHashCode() + this.country.GetHashCode();
    }
  }
}