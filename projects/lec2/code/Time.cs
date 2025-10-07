namespace code;

public class Time
{
    //public double Hours { get; set;}
    private double _seconds;

    public double Seconds
    {
        get { return _seconds; }
        set { _seconds = value; }
    }

    public double Hours
    {
        get { return _seconds / 3600; }
        set { _seconds = value * 3600; }
    }



}

