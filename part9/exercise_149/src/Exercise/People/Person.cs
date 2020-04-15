namespace Exercise
{
  public class Person
  {
    private string name { get; set; }
    private string address { get; set; }

    public Person()
    {
      this.name = "";
      this.address = "";
    }

    public Person(string name, string address)
    {
      this.name = name;
      this.address = address;
    }

    public override string ToString()
    {
      return this.name + ", " + this.address;
    }


  }
}