namespace Exercise
{
  using System.Collections.Generic;
  public class MisplacingBox : Box
  {
    Item item;

    public MisplacingBox()
    {
    }

    public override void Add(Item item)
    {
      this.item = item;
    }


    public override bool IsInBox(Item item)
    {
      return false;
    }
  }
}