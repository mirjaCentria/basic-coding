namespace exercise_131
{
  public class Item
  {
    private string identifier;
    private string name;

    public Item(string identifier, string name)
    {
      this.identifier = identifier;
      this.name = name;
    }

    public override string ToString()
    {
      return this.identifier + ": " + this.name;
    }

    public override bool Equals(object compared)
    {
      //compare with Item.identifier
      if( this.GetType().Equals(compared.GetType()) )
      {      
        Item cc = (Item)compared;
        if(this.identifier == cc.identifier)  return true;
        else return false;
      }
      else return false;
    }

    public override int GetHashCode()
    {
      return this.GetHashCode();
    }
    
  }
}