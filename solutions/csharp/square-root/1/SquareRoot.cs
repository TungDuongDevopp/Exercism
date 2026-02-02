public static class SquareRoot
{
    public static int Root(int number)
    {
       for(int i = 1;i*i <= number;i++){
           if(i*i==number) return i;
       }
        return -1;
    }
}
