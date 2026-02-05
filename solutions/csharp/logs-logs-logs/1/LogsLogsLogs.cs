// TODO: define the 'LogLevel' enum
enum  LogLevel{
    Unknown = 0,
    Trace,
    Debug,
    Info = 4,
    Warning,
    Error,
    Fatal = 42 
}
static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        int start = logLine.IndexOf('[');
        int end = logLine.IndexOf(']');
        string level = logLine[(start+1)..end];
        return level switch{
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown    
        };
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    => $"{(int)logLevel}:{message}";
}
