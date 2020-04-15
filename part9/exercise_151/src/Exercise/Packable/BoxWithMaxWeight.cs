namespace Exercise
{
  using System.Collections.Generic;
  public class BoxWithMaxWeight : Box
  {
    private int capacity;
    private List <Item> stock;
    public BoxWithMaxWeight(int capacity)
    {
      this.stock = new List<Item>();
      this.capacity = capacity;
    }

    public override string ToString()    
    {
      string items = "";
      foreach(Item item in this.stock) 
      {
        items = items + item.name + " " ;
      }
      return items;
    }

    public override void Add(Item item)
    {
      int sum = 0;
      foreach(Item stored in stock)
      {
        sum += stored.weight;
      }
      if(sum + item.weight <= capacity) this.stock.Add(item);
    }


    public override bool IsInBox(Item item)
    {
      foreach(Item stored in stock)
      {
        if(stored.Equals(item)) return true;
      }
      return false;
    }
  }
}