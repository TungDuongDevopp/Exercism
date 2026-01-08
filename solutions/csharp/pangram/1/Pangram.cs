public static class Pangram
{
    public static bool IsPangram(string input)
    {
        HashSet<char> letter = new HashSet<char>();
        
        foreach(var c in input.ToLower()){
            if(!char.IsLetter(c)) continue;
            letter.Add(c);
        }
        return letter.Count()==26;
    }
}
