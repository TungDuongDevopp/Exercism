public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var seen = new HashSet<char>();

        foreach (char c in word)
        {
            if (!char.IsLetter(c))
                continue;

            char upper = char.ToUpperInvariant(c);

            if (!seen.Add(upper))
                return false;
        }

        return true;
    }
}

