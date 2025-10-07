namespace parta;

public class Date
{
    private int _month;

    private enum _calender
    {
        January = 0,
        February = 1,
        March = 2,
        April = 3,
        May = 4,
        June = 5,
        July = 6,
        August = 7,
        September = 8,
        October = 9,
        November = 10,
        Descember = 11
    }

    public int Month
    {
        get { return _month; }
        set
        {
            if (value < 1 || value > 12)
            {
                Console.WriteLine($"The month entered: {value} is not valid");
            }
            else
            {
                _month = value;
                _calender month_text = (_calender)value - 1;

                Console.WriteLine($"The month entered is {month_text}");
            }
        }
    }

}
