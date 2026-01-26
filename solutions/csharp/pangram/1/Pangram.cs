public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var seen = new HashSet<char>();
        foreach(char c in input){
            if(!char.IsLetter(c)) continue;
            char upper =  char.ToUpperInvariant(c);
            seen.Add(upper);
        }
        return seen.Count == 26;
    }
}
