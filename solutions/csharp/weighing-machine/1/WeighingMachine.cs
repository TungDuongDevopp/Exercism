class WeighingMachine
{
    private double _weight;

    public int Precision { get; }

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }

    public double Weight
    {
        get { return _weight; }
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
            _weight = value;
        }
    }

    public double TareAdjustment { get; set; } = 5;

    public string DisplayWeight
    {
        get
        {
           double netWeight = Weight - TareAdjustment;
           return $"{netWeight.ToString($"F{Precision}")} kg";
        }
    }
}