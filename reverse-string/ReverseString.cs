using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string retVal = "";

        for(int i = 0; i < input.Length; i++)
        {
            retVal += input[input.Length - i - 1];
        }

        return retVal;
    }
}