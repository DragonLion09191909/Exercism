 class RemoteControlCar
{
    private int _speed;
    private int _battery = 100;
    private int _batteryDrain = 0;
    private int _meters;

    public int Speed { get { return _speed; } set { _speed = value < 0 ? 0 : value; } }
    public int BatteryDrain { get { return _batteryDrain; } set { _batteryDrain = value < 0 ? 1 : value; } }

    public RemoteControlCar(int speed, int batteryDrain) 
    { 
        Speed = speed; 
        BatteryDrain = batteryDrain; 
    }

    public bool BatteryDrained() => _battery < _batteryDrain; 
    
    public int DistanceDriven() => _meters;

    public void Drive()
    {
        if (!BatteryDrained()) 
        {
            _meters += Speed; 
            _battery -= BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distance;
    public int Distance { get { return _distance; } set { _distance = value < 0 ? 100 : value; } }

    public RaceTrack(int distance) { _distance = distance; }

    public bool TryFinishTrack(RemoteControlCar car)
    {
       
        while (!car.BatteryDrained() && car.DistanceDriven() < Distance)
        {
            car.Drive();
        }
        return car.DistanceDriven() >= Distance;
    }
}