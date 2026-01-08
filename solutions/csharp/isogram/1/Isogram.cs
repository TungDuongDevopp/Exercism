public static class Isogram
{
    public static bool IsIsogram(string word)
    {
       HashSet<char> letter = new HashSet<char>();
        foreach(var c in word.ToLower()){
            if(!char.IsLetter(c)) continue;
            if(!letter.Add(c)){
                return false;
            }
            
        }
        return true;
    }
}
