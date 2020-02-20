namespace exercise_122
{
  public class Product
  {
    // DO NOT TOUCH THESE VARIABLES
    private string name;
    private string location;
    private int weight;

    // CREATE YOUR CONSTRUCTORS HERE
    public Product(string name): this(name, "shelf", 1){}
    public Product(string name, string location): this(name, location,1){}
    public Product(string name, int weight): this(name, "warehouse", weight){} 

        public Product(string name, string location, int weight)
    {
      this.name = name;
      this.location = location;  
      this.weight = weight;
    } 

    // DO NOT TOUCH THIS
    public override string ToString()
    {
      return $"{this.name} ({this.weight} kg) can be found from the {this.location}.";
    }
  }
}