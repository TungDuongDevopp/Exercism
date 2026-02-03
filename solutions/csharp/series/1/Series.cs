public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        var number = new List<string>();
        if (numbers.Length < sliceLength||sliceLength<1) throw new ArgumentException();
        for(int i = 0; i<= numbers.Length - sliceLength;i++){
            number.Add(numbers.Substring(i,sliceLength));
        }
        return number.ToArray();
    }
}