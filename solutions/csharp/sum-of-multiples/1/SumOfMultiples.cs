public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
        => Enumerable.Range(0, max) 
            .Where(n => multiples.Any(m => m != 0 && n % m == 0))
            .Sum();
    
     
}