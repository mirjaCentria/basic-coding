namespace Exercise
{
  public class Book : IPackable
  {
    string author;
    string name;
    int published;

    int weight;
    public Book(string s, string s2, int i) 
    {
      this.name = s;
      this.author = s2;
      this.published = i;
      this.weight = 1;
    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.name + ": " + this.author + " (" + this.published + ")";
    }
  }
}