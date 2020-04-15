namespace Exercise
{
  public class OneItemBox : Box
  {
    Item item;

    public OneItemBox()
    {
    }

    public override void Add(Item item)
    {
      if(this.item == null) this.item = item; 
    }


    public override bool IsInBox(Item item)
    {
      if(this.item.Equals(item)) return true;
      else return false;
    }
  }
}