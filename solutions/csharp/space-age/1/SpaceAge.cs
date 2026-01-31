public class SpaceAge
{   
    private readonly double _yearsOnEarth;
    public SpaceAge(long seconds)
    {
     _yearsOnEarth = seconds / 31557600.0;
    }

   public double OnEarth()
    => Math.Round(_yearsOnEarth, 2);

    public double OnMercury()
    => Math.Round(_yearsOnEarth / 0.2408467, 2);

public double OnVenus()
    => Math.Round(_yearsOnEarth / 0.61519726, 2);

public double OnMars()
    => Math.Round(_yearsOnEarth / 1.8808158, 2);

public double OnJupiter()
    => Math.Round(_yearsOnEarth / 11.862615, 2);

public double OnSaturn()
    => Math.Round(_yearsOnEarth / 29.447498, 2);

public double OnUranus()
    => Math.Round(_yearsOnEarth / 84.016846, 2);

public double OnNeptune()
    => Math.Round(_yearsOnEarth / 164.79132, 2);
}

