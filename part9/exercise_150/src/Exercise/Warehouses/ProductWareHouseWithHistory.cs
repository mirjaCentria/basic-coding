namespace Exercise
{
  public class ProductWarehouseWithHistory : ProductWarehouse
  {
    ChangeHistory history;
    public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
    {
      history = new ChangeHistory();
      this.balance = initialBalance;
      history.Add(initialBalance);
    }

    public string History()
    {
      return history.ToString();
    }

    new public void AddToWarehouse(int amount) 
    {
      base.AddToWarehouse(amount);
      this.history.Add(this.balance);
    }

    new public int TakeFromWarehouse(int amount) 
    {
      base.TakeFromWarehouse(amount);
      this.history.Add(this.balance);
      return amount;
    }
  }
}