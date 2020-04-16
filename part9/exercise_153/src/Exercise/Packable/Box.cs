using System.Collections.Generic;

namespace Exercise
{
  public class Box : IPackable
  {
    int capacity;
    int load;
    
    List<IPackable> items;
    public Box(int i)
    {
      this.capacity = i;
      items = new List<IPackable>();
    }

    public void Add(IPackable item)
    {
     // System.Console.WriteLine(item.Weight() + " ");
     // System.Console.WriteLine(this.load + " ");
     // System.Console.WriteLine(this.capacity);
      if(item.Weight() + this.load <= this.capacity) 
      {
        
        this.load += item.Weight();
        this.items.Add(item);
      }
        
    }

    public int Weight()
    {
      return this.load;
    }

    public override string ToString()
    {
      return items.Count + " items, total weight " + this.load + " kg";
    }
  }
}