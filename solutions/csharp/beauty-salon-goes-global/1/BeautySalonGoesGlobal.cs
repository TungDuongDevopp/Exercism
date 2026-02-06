using System.Data;
using System.Globalization;
using System.Linq.Expressions;
public enum Location
{
    NewYork,
    London,
    Paris
}
public enum AlertLevel
{
    Early = 1440, // 1 day in minutes
    Standard = 105,
    Late = 30
}
public static class Appointment
{
    private static TimeZoneInfo ToTimeZone(Location location) =>
        location switch 
        {
            Location.NewYork => TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
            Location.London => TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"),
            Location.Paris => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
            _ => throw new ArgumentOutOfRangeException("Not correct location!")
        };
    private static CultureInfo ToCulture(Location location) =>
        location switch 
        {
            Location.NewYork => new CultureInfo("en-US"),
            Location.London => new CultureInfo("en-GB"),
            Location.Paris => new CultureInfo("fr-FR"),
            _ => throw new ArgumentOutOfRangeException("Not correct location!")
        };
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();
    public static DateTime Schedule(string appointmentDateDescription, Location location) => 
        TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription), ToTimeZone(location));
    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) => 
        appointment.AddMinutes(-(double)alertLevel);
    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var timeZoneInfo = ToTimeZone(location);
        return timeZoneInfo.IsDaylightSavingTime(dt) != timeZoneInfo.IsDaylightSavingTime(dt.AddDays(-7));
    }
    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        DateTime normalizedDateTime;
        try
        {
            normalizedDateTime = DateTime.Parse(dtStr, ToCulture(location));
        }
        catch (FormatException)
        {
            normalizedDateTime = new DateTime(1, 1, 1, 0, 0, 0);
        }
        return normalizedDateTime;
    }
}
