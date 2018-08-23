using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        bool retVal = true;
        List<string> alphabet = new List<string>()
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };
        foreach(char c in input)
        {
            if(char.IsLetter(c))
            {
                string s = char.ToString(c).ToLower();
                if (!alphabet.Contains(s))
                {
                    retVal = false;
                    return retVal;
                }
            }
        }

        return retVal;
    }
}
