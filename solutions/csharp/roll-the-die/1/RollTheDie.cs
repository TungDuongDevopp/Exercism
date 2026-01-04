public class Player
{
    public int RollDie()
    {
       Random randomNumber = new Random();
        return randomNumber.Next(1,19);
    }

    public double GenerateSpellStrength()
    {
        Random randomStrength = new Random();
        return randomStrength.NextDouble()*100;
    }
}
