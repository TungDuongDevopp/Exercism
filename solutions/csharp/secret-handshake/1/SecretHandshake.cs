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
        var result = new List<string>();

        foreach (var (bit, action) in Actions)
        {
            if ((commandValue & bit) != 0)
                result.Add(action);
        }

        if ((commandValue & 16) != 0)
            result.Reverse();

        return result.ToArray();
    }
}

