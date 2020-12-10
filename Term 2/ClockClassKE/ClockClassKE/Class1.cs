using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Clock
{
    int hour;
    int minute;
    int second;

    public void tellTime()
    {
        Console.WriteLine(hour.ToString() + ":" + minute.ToString() + ":" + second.ToString());
    }
}