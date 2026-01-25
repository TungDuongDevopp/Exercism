public static class SecretHandshake
{
    private static readonly (int bit, string action)[] Actions =
    {
        (1, "wink"),
        (2, "double blink"),
        (4, "close your eyes"),
        (8, "jump")
    };

    public static string[] Commands(int commandValue)
    {
        var commands = Actions
            .Where(a => (commandValue & a.bit) != 0)
            .Select(a => a.action)
            .ToList();

        if ((commandValue & 16) != 0)
            commands.Reverse();

        return commands.ToArray();
    }
}
