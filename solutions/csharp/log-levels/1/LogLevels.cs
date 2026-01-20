static class LogLine
{
    public static string Message(string logLine)
        => Parse(logLine).message;

    public static string LogLevel(string logLine)
        => Parse(logLine).level;

    public static string Reformat(string logLine)
    {
        var (level, message) = Parse(logLine);
        return $"{message} ({level})";
    }

    private static (string level, string message) Parse(string logLine)
    {
        if (string.IsNullOrWhiteSpace(logLine))
            throw new ArgumentException();
        int levelStart = logLine.IndexOf('[') + 1;
        int levelEnd = logLine.IndexOf(']');
        int messageStart = logLine.IndexOf(": ") + 2;

        var level = logLine[levelStart..levelEnd].ToLower();
        var message = logLine[messageStart..].Trim();

        return (level, message);
    }
}
