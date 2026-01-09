static class Badge
{
    public static string Print(int? id, string name, string? department)
    {   string badges="";
         department ??= "owner";
        if (id==null){
            badges = $"{name} - {department.ToUpper()}";
        }
        else{
        badges = $"[{id}] - {name} - {department.ToUpper()}";
        }
            return badges;
            
       
    }
}
