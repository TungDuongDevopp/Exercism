using System.Text;
public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var sb = new StringBuilder();
        foreach(char c in  phoneNumber){
            if (!char.IsDigit(c)) continue;
            sb.Append(c);
        }
       string cleanNumber = sb.ToString();
        if(cleanNumber[0]=='1') cleanNumber = cleanNumber[1..];
        if(cleanNumber[0]-'0'<2 ||cleanNumber[3] -'0'<2||cleanNumber.Length!=10) throw new ArgumentException();
        return cleanNumber;
    }
}