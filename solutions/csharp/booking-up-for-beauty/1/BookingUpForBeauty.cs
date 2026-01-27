static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    { DateTime.TryParse(appointmentDateDescription, out DateTime date);
     return date;
    }   
    

    public static bool HasPassed(DateTime appointmentDate)
    => DateTime.Now > appointmentDate;
        
    

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    =>  appointmentDate.Hour>=12 && appointmentDate.Hour<18;
       
    public static string Description(DateTime appointmentDate)
    {  string date = appointmentDate.ToString("M/d/yyyy h:mm:ss tt");
       return $"You have an appointment on {date}.";
    }
    
    public static DateTime AnniversaryDate()
    => new DateTime(DateTime.Now.Year,9,15,0,0,0);
        
}
