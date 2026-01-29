public static class Triangle
{
  public static bool IsEquilateral(double a, double b, double c)
    => IsTriangle(a, b, c) && a == b && b == c;

public static bool IsIsosceles(double a, double b, double c)
    => IsTriangle(a, b, c) && (a == b || b == c || a == c);

public static bool IsScalene(double a, double b, double c)
    => IsTriangle(a, b, c) && a != b && b != c && a != c;

private static bool IsTriangle(double a, double b, double c)
    => a > 0 && b > 0 && c > 0
       && a + b > c
       && a + c > b
       && b + c > a;

}