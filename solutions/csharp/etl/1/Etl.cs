public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var newDic = new Dictionary<string, int>();

        foreach (var kvp in old)
        {
            var number = kvp.Key;
            var letters = kvp.Value;

            foreach (var letter in letters)
            {
                newDic[letter.ToLower()] = number;
            }
        }

        return newDic;
    }
}
