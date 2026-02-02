public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        var result = new List<long>();
        long n = number;
        long i = 2;

        while (n > 1)
        {
            if (n % i == 0)
            {
                result.Add(i);
                n /= i;
            }
            else
            {
                i++;
            }
        }

        return result.ToArray();
    }
}
