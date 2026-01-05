public static class ReverseString
{
    public static string Reverse(string input)
    {
        string reversed = new string(input.Reverse().ToArray());
        return reversed;
    }
}