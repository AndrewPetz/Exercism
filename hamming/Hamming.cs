using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int retVal = 0;
        if(firstStrand.Length == secondStrand.Length)
        {
            for(int i = 0; i < firstStrand.Length; i++)
            {
                if(firstStrand[i] != secondStrand[i])
                {
                    retVal++;
                }
            }
            return retVal;
        } else
        {
            throw new ArgumentException();
        }
    }
}