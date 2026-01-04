public static class Triangle
{   
    public static bool IsTriangle(double a, double b, double c){
        return (a>0 && b>0 && c>0)&&
            (a+b>c && b+c>a && c+a>b);
    }
    public static bool IsScalene(double a, double b, double c)
    {
       return IsTriangle(a,b,c) &&(a!=b && b!=c && c!=a);
    }

    public static bool IsIsosceles(double a, double b, double c) 
    {
         return IsTriangle(a,b,c) &&(a==b || b==c || c==a);
    }

    public static bool IsEquilateral(double a, double b, double c) 
    {
          return IsTriangle(a,b,c) &&(a==b && b==c && c==a);
    }
}