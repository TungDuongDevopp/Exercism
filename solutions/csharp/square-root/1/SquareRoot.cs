public static class SquareRoot
{
    public static int Root(int number)
    {
        int squareroot=0;
        for(int i=1;i<=number;i++){
            if(i*i==number){
                squareroot+=i;
                break;
            }
            
        }
        return squareroot;
    }
}
