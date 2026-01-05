static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime date = DateTime.Parse(appointmentDateDescription); 
        return date;
    }

    public static bool HasPassed(DateTime appointmentDate)
    => appointmentDate< DateTime.Now;

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    => appointmentDate.Hour>=12&&appointmentDate.Hour<18;
    public static string Description(DateTime appointmentDate)
    {
       string dateTime = appointmentDate.ToString("M/d/yyyy h:mm:ss tt");
        return $"You have an appointment on {dateTime}.";
        }
    public static DateTime AnniversaryDate()
    => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    
}
