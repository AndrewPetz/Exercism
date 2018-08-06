using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int retVal = 0;
        foreach(int i in multiples)
        {
            retVal += CalculateMultiple(i, max);
        }
        return retVal;
    }

    public static int CalculateMultiple(int multiple, int max)
    {
        int i = 0;
        int retVal = 0;

        while(i < max)
        {
            retVal += i;
            i += multiple;
        }

        return retVal;
    }
}