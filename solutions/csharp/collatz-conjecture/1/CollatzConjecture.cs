public static class CollatzConjecture
{
    public static int Steps(long number)
    {   int step = 0;
        if (number <=0) throw new ArgumentOutOfRangeException();
        while(number>1){
            if(number % 2 == 0 ) number/=2;
            else {number = 3 * number + 1;}
            step ++;
            
        }
     return step;
    }
}