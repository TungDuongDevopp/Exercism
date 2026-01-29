public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    => IsTriagle(side1,side2,side3) && (side1 != side2 && side2 != side3 && 
        side3 != side1);
     
    public static bool IsIsosceles(double side1, double side2, double side3) 
     => IsTriagle(side1,side2,side3) && (side1 == side2 || side2 == side3 || 
        side3 == side1);
       
    public static bool IsEquilateral(double side1, double side2, double side3) 
    => IsTriagle(side1,side2,side3) && (side1 == side2 && side2 == side3 && 
        side3 == side1);
        
    
    public static bool IsTriagle(double a,double b, double c)
       => (a>0 && b>0 && c>0 )&& (a + b >=c && a+c>=b && b+c>=a);
}