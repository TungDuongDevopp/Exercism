public static class ArmstrongNumbers{
    public static bool IsArmstrongNumber(int number){
        string s = number.ToString();
        int count = s.Length;
        int sum = 0;
        foreach (char c in s){
            int digit = (int)char.GetNumericValue(c);
            sum += (int)Math.Pow(digit, count);
        }
        return sum == number;
    }
}    