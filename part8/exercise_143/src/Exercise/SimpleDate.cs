using System.Reflection;
namespace Exercise
{
  public class SimpleDate
  {
    private int day;
    private int month;
    private int year;

    public SimpleDate(int day, int month, int year)
    {
      this.day = day;
      this.month = month;
      this.year = year;
    }

    public override string ToString()
    {
      return this.day + "." + this.month + "." + this.year;
    }

    public bool Earlier(SimpleDate compared)
    {
      if (this.year < compared.year)
      {
        return true;
      }
      if (this.year == compared.year && this.month < compared.month)
      {
        return true;
      }
      if (this.year == compared.year && this.month == compared.month &&
          this.day < compared.day)
      {
        return true;
      }
      return false;
    }

    public override bool Equals(object compared)
    {
         // SimpleDate sd = new SimpleDate();
      if((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }
      
      SimpleDate sd = (SimpleDate)compared;

      if (this.year != sd.year)
      {
        return false;
      }
      if (this.month != sd.month)
      {
        return false;
      }
      if (this.day != sd.day)
      {
        return false;
      }
      return true;
    }

    public override int GetHashCode()
    {
      return this.year + this.month + this.day;
    }
  }
}