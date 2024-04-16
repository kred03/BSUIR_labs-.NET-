using System;

public class DateService
{
    public string GetDay(string date)
    {
        DateTime parsedDate;
        if (DateTime.TryParse(date, out parsedDate))
        {
            return parsedDate.ToString("dddd");
        }
        else
        {
            return "Некорректный формат даты";
        }
    }

    public int GetDaysSpan(int day, int month, int year)
    {
        DateTime currentDate = DateTime.Now;
        DateTime targetDate = new DateTime(year, month, day);

        TimeSpan span = targetDate.Date - currentDate.Date;
        return span.Days;
    }
}