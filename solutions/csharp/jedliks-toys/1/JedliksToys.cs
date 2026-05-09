class RemoteControlCar
{
     private int _battery=100;
  private int _meters;
  public static RemoteControlCar Buy()=> new RemoteControlCar();

  public string DistanceDisplay() => $"Driven {_meters} meters";



   public string BatteryDisplay()=> _battery <= 0 ? "Battery empty" : $"Battery at {_battery}%";


  public void Drive()
  {
      _meters += _battery > 0 ? 20 : 0;
      _battery -=_battery>0? 1:0;
  }
}
