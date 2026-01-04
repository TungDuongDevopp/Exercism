public static class EliudsEggs
{
    public static int EggCount(int n)
    {
        int cnt=0;
        while(n>0){
            int du = n%2;
            if(du==1){
                cnt++;
            }
            n/=2;
        }
        return cnt;
    }
}
