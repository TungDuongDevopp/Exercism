public class Player
{
    public Random rd = new Random();
    public int RollDie()
    => rd.Next(1,19);
    
    public double GenerateSpellStrength()
    => rd.NextDouble()*100;
        
    
}
