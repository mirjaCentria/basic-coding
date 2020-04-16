using System;

namespace Exercise
{
  public class Organism : IMovable
  {
    private int x;
    private int y;

        public Organism()
        {
          this.x = 0;
          this.y = 0;
        }

        public Organism(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
    public void Move(int dx, int dy)
    {
      this.x += dx;
     // this.x = Math.Abs(this.x);
      this.y += dy;
     // this.y = Math.Abs(this.y);
    }

    public override string ToString()
    {
      return "x: " + x + "; y: " + y;
    }
  }
}