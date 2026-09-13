class RemoteControlCar
{
    private int _distanceTraveled = 0;
    private int _remainingBattery = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceTraveled} meters";
    }

    public string BatteryDisplay()
    {
        return _remainingBattery > 0
            ? $"Battery at {_remainingBattery}%" 
            : "Battery empty";
    }

    public void Drive()
    {
        if (_remainingBattery > 0)
        {
            _distanceTraveled += 20;
            _remainingBattery -= 1;
        }
    }
}
