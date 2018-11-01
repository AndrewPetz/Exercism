using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        bool retVal = true;
        string lowerInput = input.ToLower();
        List<string> alphabet = new List<string>()
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };
        foreach(string s in alphabet)
        {
            if(char.IsLetter(s[0]))
            {
                string lower = s.ToLower();
                if (!lowerInput.Contains(lower))
                {
                    retVal = false;
                    return retVal;
                }
            }
        }

        return retVal;
    }
}
