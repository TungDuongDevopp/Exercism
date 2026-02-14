public static class CentralBank
{
    public static string DisplayDenomination(long salaryBase, long multiplier){
    try 
    {
       
        long denomination = checked(salaryBase * multiplier);
        return denomination.ToString();
    }  
    catch(OverflowException)
    {
        return "*** Too Big ***";
    }
}
    public static string DisplayGDP(float salaryBase, float multiplier)
    {
        float denomination = salaryBase * multiplier;
        if(float.IsInfinity(denomination)) return "*** Too Big ***";
        return denomination.ToString();
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
       try 
    {
       
        decimal denomination = checked(salaryBase * multiplier);
        return denomination.ToString();
    }  
    catch(OverflowException)
    {
        return "*** Much Too Big ***";
    }
    }
}
