namespace Exercise
{
  public class Furniture : IPackable
  {
    string type;
    string color;

    int weight;

    public Furniture(string s, string s2, int i)
    {
      this.type = s;
      this.color = s2;
      this.weight = i;
    }

    public int Weight()
    {
      return weight;
    }

    public override string ToString()
    {
      return this.color + " " + this.type + " - weight " + this.weight + " kg";
    }
  }
}