static class LogLine
{
    public static string Message(string logLine)
    {
         string message = logLine.Split(':')[1];
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']')-1;
        string level = logLine.Substring(start, end);
        return level.ToLower();
    }

    public static string Reformat(string logLine)
    {
     return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
