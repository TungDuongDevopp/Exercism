public static class Bob
{
    public static string Response(string statement)
    => statement.Trim() switch{
       var s when string.IsNullOrWhiteSpace(s) => "Fine. Be that way!",
       var s when s.All(c => !char.IsLower(c)) && s.Any(char.IsLetter) && s[^1]=='?'
        =>  "Calm down, I know what I'm doing!",     
       var s when s.All(c => !char.IsLower(c)) && s.Any(char.IsLetter) => "Whoa, chill out!",     
       var s when s[^1]=='?' =>  "Sure.",    
       _=> "Whatever."    
            
    };
       
    
}