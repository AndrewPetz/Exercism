using System;

public class Robot
{
    private string RobotName;

    public string Name
    {
        get
        {
            if(string.IsNullOrEmpty(RobotName))
            {
                Random rand = new Random(DateTime.UtcNow.Millisecond);
                string retVal = "";
                
                retVal += RandomChar();
                retVal += RandomChar();
                retVal += rand.Next(0, 9);
                retVal += rand.Next(0, 9);
                retVal += rand.Next(0, 9);

                RobotName = retVal;
            }
            
            return RobotName;
        }
        set
        {
            RobotName = value;
        }
    }

    public void Reset()
    {
        Name = "";
        string name = Name;
    }

    public char RandomChar()
    {
        Random rand = new Random(DateTime.UtcNow.Millisecond);
        return (char)('A' + rand.Next(0, 26));
    }
}