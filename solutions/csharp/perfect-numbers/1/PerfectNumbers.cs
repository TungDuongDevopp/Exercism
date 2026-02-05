public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {  if(number<1) throw new ArgumentOutOfRangeException(); 
        int sum = 0 ;
        for(int i = 1;i<=number/2;i++){
            if(number % i == 0) sum+=i;
        }
     if(number==sum) return Classification.Perfect;
     else if(number<sum ) return Classification.Abundant;
     return Classification.Deficient;
    }
}
