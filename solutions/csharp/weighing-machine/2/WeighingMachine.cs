class WeighingMachine
{
    private double _weight;
    
    public WeighingMachine(int precision){
        Precision = precision;
    }
    public int Precision{get;}
    
    public double Weight{
        get{
            return _weight;
        }
        set{
            if(value <0) throw new ArgumentOutOfRangeException();
            _weight = value;
        }
    }
    public double TareAdjustment{get;set;} = 5;
    
    public string DisplayWeight{
        get{
            double displayWeight = Weight -TareAdjustment;
            return $"{displayWeight.ToString($"F{Precision}")} kg";
        }
    }
    
}
