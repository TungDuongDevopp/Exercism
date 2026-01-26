using System.Collections;

public static class FlattenArray
{
    public static IEnumerable Flatten(IEnumerable input)
    {
        foreach(var item in input){
            if (item==null) continue;
            if(item is int number) yield return number;
             else if (item is IEnumerable nested)
            {
                foreach (var n in Flatten(nested))
                    yield return n;
            }
        }
    }
}