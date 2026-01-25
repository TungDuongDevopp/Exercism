public static class ResistorColor
{ 
    private static readonly  string[] colorCode={
"black","brown","red","orange","yellow","green","blue","violet","grey","white"
    };
    public static int ColorCode(string color)
    => Array.IndexOf(colorCode,color);
    public static string[] Colors()
    => colorCode;
}