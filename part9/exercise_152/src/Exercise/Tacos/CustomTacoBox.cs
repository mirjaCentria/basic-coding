namespace Exercise
{
  public class CustomTacoBox : ITacoBox
  {
    private int tacos;
    public CustomTacoBox(int tacos)
    {
      this.tacos = tacos;
    }

    public int TacosRemaining()
    {
      return tacos;
    }

    public void Eat()
    {
      if(tacos > 0) tacos--;
    }
  }
}