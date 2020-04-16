namespace Exercise
{
  using System.Collections.Generic;
  public class Herd : IMovable
  {
    private List<IMovable> herd;
    public Herd()
    {
      herd = new List<IMovable>();
    }

    public void AddToHerd(IMovable m)
    {
      this.herd.Add(m);
    }

    public void Move(int dx, int dy)
    {
      foreach(IMovable m in herd)
      {
        m.Move(dx, dy);
      }
    }

    public override string ToString()
    {
      string line = "";
      foreach(IMovable m in herd)
      {
        line += m.ToString() + "\n";
      }
      return line;
    }
  }
}