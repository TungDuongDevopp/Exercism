public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork = phoneNumber[..3]== "212";
        bool IsFake = phoneNumber[4..7] =="555";
        string LocalNumber = phoneNumber[8..];
        return(IsNewYork,IsFake,LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    => phoneNumberInfo.IsFake;
       
    
}
