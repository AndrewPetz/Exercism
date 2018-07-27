using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime birthDate)
    {
        const int SECONDS_ADDED = 1000000000;
        return birthDate.AddSeconds(SECONDS_ADDED);
    }
}