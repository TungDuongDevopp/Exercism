public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }
    public CarTelemetry Telemetry { get; private set; }
    private Speed currentSpeed;
    public RemoteControlCar() => Telemetry = new(this);
    public string GetSpeed() => currentSpeed.ToString();
    private void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;
    private void SetSpeed(Speed speed) => currentSpeed = speed;
    public class CarTelemetry(RemoteControlCar car)
    {
        private readonly RemoteControlCar _car = car;
        public void Calibrate() { }
        public bool SelfTest() => true;
        public void ShowSponsor(string sponsor) => _car.SetSponsor(sponsor);
        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
            if (unitsString == "cps")
            {
                speedUnits = SpeedUnits.CentimetersPerSecond;
            }
            _car.SetSpeed(new Speed(amount, speedUnits));
        }
    }
    public enum SpeedUnits
    {
        MetersPerSecond,
        CentimetersPerSecond
    }
    public struct Speed(decimal amount, SpeedUnits speedUnits)
    {
        public decimal Amount { get; } = amount;
        public SpeedUnits SpeedUnits { get; } = speedUnits;
        public override string ToString() => $"{Amount} {(SpeedUnits == SpeedUnits.CentimetersPerSecond ? "centimeters per second" : "meters per second")}";
    }
}