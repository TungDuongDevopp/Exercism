public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        var result = new List<string>();

        if ((commandValue & 1) != 0)
            result.Add("wink");

        if ((commandValue & 2) != 0)
            result.Add("double blink");

        if ((commandValue & 4) != 0)
            result.Add("close your eyes");

        if ((commandValue & 8) != 0)
            result.Add("jump");

        if ((commandValue & 16) != 0)
            result.Reverse();

        return result.ToArray();
    }
}
