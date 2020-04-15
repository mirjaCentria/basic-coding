namespace Exercise
{
  public class Student : Person
  {
    private int credits { get; set; }

    public Student()    
    {
      this.credits = 0;
    }

    public Student(string name, string address, int credits) : 
      base(name, address)
    {
      this.credits = credits;
    }

    public Student(string name, string address) : 
      base(name, address)
    {
      this.credits = 0;
    }

    public override string ToString()
    {
      return base.ToString() + " credits: " + this.credits;
    }

    public void Study()
    {
      this.credits++;
    }

  }
}