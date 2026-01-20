class Lasagna
{
   public int ExpectedMinutesInOven()
       => 40;
    
   public int RemainingMinutesInOven(int minute)
       => ExpectedMinutesInOven() - minute;
    
   public int PreparationTimeInMinutes(int layer)
       => 2*layer;
    
    public int ElapsedTimeInMinutes(int layer,int minute)
        => PreparationTimeInMinutes(layer)+ minute;
}
