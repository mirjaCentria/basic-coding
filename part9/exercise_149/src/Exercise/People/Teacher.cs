namespace Exercise
{
  public class Teacher : Person
  {
    private int salary { get; set; }

    public Teacher()    
    {
      this.salary = 0;
    }

    public Teacher(string name, string address, int salary) : 
      base(name, address)
    {
      this.salary = salary;
    }

    public Teacher(string name, string address) : 
      base(name, address)
    {
      this.salary = 0;
    }

    public override string ToString()
    {
      return base.ToString() + " salary " + this.salary + " per month";
    }
  }
}