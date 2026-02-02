public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
       var dic = new Dictionary<char,int>{
           ['A'] = 0,
           ['C'] = 0,
           ['G'] = 0,
           ['T'] = 0
       };
       if (!sequence.All(x=>dic.ContainsKey(x)))  throw new ArgumentException();
        foreach(var c in sequence.ToUpper()){
            if(dic.ContainsKey(c)) dic[c]++;
        }
        return dic;
    }
}