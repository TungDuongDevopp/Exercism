public class SpaceAge
{
    private int seconds;
    private double yearOnEarth ;
    public SpaceAge(int seconds)
    {
        this.seconds=seconds;
        yearOnEarth=seconds / 31557600.0;
    }

    public double OnEarth()
    => yearOnEarth ;

    public double OnMercury()
    => yearOnEarth /0.2408467;

    public double OnVenus()
    => yearOnEarth / 0.61519726;

    public double OnMars()
    => yearOnEarth / 1.8808158;

    public double OnJupiter()
    => yearOnEarth / 11.862615;

    public double OnSaturn()
    => yearOnEarth / 29.447498;

    public double OnUranus()
    => yearOnEarth / 84.016846;

    public double OnNeptune()
    =>yearOnEarth / 164.79132;
}