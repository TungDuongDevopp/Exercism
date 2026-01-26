public static class Isogram
{
     
    public static bool IsIsogram(string word)
    {    var alphabet = new HashSet<char>();
       foreach(char c in word.ToUpper()){
           if(!char.IsLetter(c)) continue;
           if(!alphabet.Add(c)) return false;
       }
        return true;
    }
}
