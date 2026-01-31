using System.Text;
public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var sb = new StringBuilder();
        bool canAdd = false;
        bool needLower = false;
        foreach(char c in phrase){
        char kytu = needLower ? char.ToLower(c) : char.ToUpper(c);

         if(!char.IsLetter(c)){
             if(c=='-'||char.IsWhiteSpace(c)){
                 canAdd = true;
                 needLower = false;
             }
         }
         else{
             if(char.IsUpper(c)){
                 canAdd = true;
                 needLower = true;   
             }
             if(canAdd&&char.IsUpper(kytu)){
                sb.Append(kytu);
                canAdd = false; 
             }
         }   
           
        }
        return sb.ToString(); 
     }
           
}
