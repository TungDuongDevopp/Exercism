using System.Text;
public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var number = new string(phoneNumber.Where(c=>char.IsDigit(c)).ToArray());
       
        if(number[0]=='1') number = number[1..];
        if(number[0]<'2' ||number[3]<'2'||number.Length!=10) throw new ArgumentException();
        return number;
    }
}