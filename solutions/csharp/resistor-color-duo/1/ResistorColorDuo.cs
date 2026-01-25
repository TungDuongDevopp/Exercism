public static class ResistorColorDuo
{ 
    private static readonly string[] _colors={
"black","brown","red","orange","yellow","green","blue","violet","grey","white"
    };
    public static int Value(string[] colors)
    {  
       int firstColor = Array.IndexOf(_colors,colors[0]);
       int secondColor = Array.IndexOf(_colors,colors[1]);
        return firstColor*10 + secondColor;
    }
}
