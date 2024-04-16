using System.Globalization;

public class DateService
{
    public static string GetDay(string date)
    {
        if (DateTime.TryParse(date, out DateTime parsedDate))
        {
            return parsedDate.DayOfWeek.ToString();
        }
        else
        {
            throw new ArgumentException("Неверный формат даты");
        }
    }

    public static int GetDaysSpan(int day, int month, int year)
    {
        DateTime currentDate = DateTime.Today;
        DateTime futureDate;

        try
        {
            futureDate = new DateTime(year, month, day);
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new ArgumentException("Неверно указаны день, месяц или год");
        }

        if (futureDate < currentDate)
        {
            throw new ArgumentException("Указанная дата находится в прошлом");
        }

        return (futureDate - currentDate).Days;
    }
}