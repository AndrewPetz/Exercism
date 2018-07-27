using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        string retVal = "";
        foreach (char c in nucleotide) {
            if (c.Equals('G'))
            {
                retVal += 'C';
            }
            if (c.Equals('C'))
            {
                retVal += 'G';
            }
            if (c.Equals('T'))
            {
                retVal += 'A';
            }
            if (c.Equals('A'))
            {
                retVal += 'U';
            }
        }

        return retVal;
    }
}