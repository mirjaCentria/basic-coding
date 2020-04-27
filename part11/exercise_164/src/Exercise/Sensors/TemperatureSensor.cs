namespace Exercise
{
  using System;
  public class TemperatureSensor : Sensor
  {
    bool state = false;
    Random rndom;

    public bool IsOn()
    {
      return state;
    }

    public void SetOn()
    {
      state = true;
    }

    public void SetOff()
    {
      state = false;
    }

    public int Read()
    {
      if(!this.IsOn()) 
      {
        throw new InvalidOperationException("Temperature sensor is off!");        
      } 
      this.rndom = new Random();
      return this.rndom.Next(1,60) - 30;
    }
  }
}