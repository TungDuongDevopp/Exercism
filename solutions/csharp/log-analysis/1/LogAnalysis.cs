public static class LogAnalysis 
{

    public static string SubstringAfter(this string source, string delimiter ){
        int index = source.IndexOf(delimiter) + delimiter.Length;
        return source[index..];
    }
        public static string SubstringBetween(this string source, string delimiter1,string delimiter2 ){
            int start = source.IndexOf(delimiter1) + delimiter1.Length;
            int end = source.IndexOf(delimiter2, start);
            return source[start..end];
        }
    public static string Message(this string source)
        => source.SubstringAfter(": ");
     public static string LogLevel(this string source)
         => source.SubstringBetween("[","]");
   
}