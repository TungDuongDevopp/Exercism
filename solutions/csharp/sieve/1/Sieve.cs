public static class Sieve
{
    public static int[] Primes(int n)
    {   if(n<2) return [];
        bool[] number = new bool[n+1];
        for(int i=2;i<=n;i++){
            number[i]=true;
        }
      for (int i = 2; i * i <= n; i++)
        {
            if (number[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    number[j] = false;
                }
            }
        }
      var result = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            if (number[i])
            {
                result.Add(i);
            }
        }

        return result.ToArray();
        
    }
}