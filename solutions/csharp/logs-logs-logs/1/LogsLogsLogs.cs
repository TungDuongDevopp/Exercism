// TODO: define the 'LogLevel' enum
  enum LogLevel{
    Unknown =0,
    Trace,
    Debug,
    Info=4,
    Warning,
    Error,
    Fatal=42 
}
static class LogLine
{
  
    public static LogLevel ParseLogLevel(string logLine)
    { 
       string[] word= logLine.Split(':');
       string logWord = word[0][1..^1].ToUpper();
       return logWord switch
    {
        "TRC" => LogLevel.Trace,
        "DBG" => LogLevel.Debug,
        "INF" => LogLevel.Info,
        "WRN" => LogLevel.Warning,
        "ERR" => LogLevel.Error,
        "FTL" => LogLevel.Fatal,
        _     => LogLevel.Unknown // Dấu gạch dưới đại diện cho 'default'
    };
       } 
    

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {  int value = (int)logLevel;
        return $"{value}:{message}";         
        
    }
}
