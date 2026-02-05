using System.Text;
public static class RnaTranscription
{ 
    private static readonly Dictionary <char,char> Nucleotit = new(){
        ['G'] = 'C',
        ['C'] = 'G',
        ['T'] = 'A',
        ['A'] = 'U'
    };
    public static string ToRna(string strand)
    {   var sb = new StringBuilder();
     if(strand =="") return string.Empty;
       if(strand is null||
         strand.All(x=> !Nucleotit.ContainsKey(x))
         ) throw new ArgumentException();
        foreach(var c in strand.ToUpper()){
         sb.Append(Nucleotit[c]);   
        }
     return sb.ToString();
    }
}