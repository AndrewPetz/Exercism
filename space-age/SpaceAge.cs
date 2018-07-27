using System;

public class SpaceAge
{
    public long INPUT;
    public Double EARTH_SECONDS = 31557600;

    public SpaceAge(long seconds)
    {
        INPUT = seconds;
    }

    public double OnEarth()
    {
        return Math.Round((Double)INPUT/EARTH_SECONDS, 2);
    }

    public double OnMercury()
    {
        return Math.Round(OnEarth()/0.2408467, 2);
    }

    public double OnVenus()
    {
        return Math.Round(OnEarth() / 0.6159726, 2);
    }

    public double OnMars()
    {
        return Math.Round(OnEarth() / 1.8808158, 2);
    }

    public double OnJupiter()
    {
        return Math.Round(OnEarth() / 11.862615, 2);
    }

    public double OnSaturn()
    {
        return Math.Round(OnEarth() / 29.447498, 2);
    }

    public double OnUranus()
    {
        return Math.Round(OnEarth() / 84.016846, 2);
    }

    public double OnNeptune()
    {
        return Math.Round(OnEarth() / 164.79132, 2);
    }
}