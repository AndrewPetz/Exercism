using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        string retVal = "";
        statement = statement.Trim();
        bool hasLetters = statement.Any(x => char.IsLetter(x));

        if (statement.Length == 0)
        {
            retVal = "Fine. Be that way!";
            return retVal;
        }
        if (statement.EndsWith("?"))
        {
            if(hasLetters && statement.Equals(statement.ToUpper(), StringComparison.Ordinal)) {
                retVal = "Calm down, I know what I'm doing!";
            } else
            {
                retVal = "Sure.";
            }
            
        } else if (hasLetters && statement.Equals(statement.ToUpper(), StringComparison.Ordinal))
        {
            retVal = "Whoa, chill out!";
        } else if(String.IsNullOrWhiteSpace(statement))
        {
            retVal = "Fine. Be that way!";
        } else
        {
            retVal = "Whatever.";
        }

        return retVal;
    }
}