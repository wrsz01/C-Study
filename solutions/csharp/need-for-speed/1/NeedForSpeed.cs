class RemoteControlCar(int rate, int batteryDrain)
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public readonly int rate = rate;
    public readonly int batteryDrain = batteryDrain;
    private int _battery = 100;
    private int _distanceDrive = 0;

    public bool BatteryDrained()
    {
        return _battery < batteryDrain;
    }

    public int DistanceDriven()
    {
        return this._distanceDrive;
    }

    public void Drive()
    {
        if (BatteryDrained()) return;
        _distanceDrive += rate;
        _battery -= batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new(50, 4);
    }
}

class RaceTrack(int distance)
{
    // TODO: define the constructor for the 'RaceTrack' class
    private readonly int _distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        return 100 / car.batteryDrain * car.rate >= _distance;
    }
}
