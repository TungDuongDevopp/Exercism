using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();
        bool capitalizeNext = false;

        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                sb.Append('_');
            }
            else if (char.IsControl(c))
            {
                sb.Append("CTRL");
            }
            else if (c == '-')
            {
                capitalizeNext = true;
            }
            else if (char.IsLetter(c))
            {
                if (IsGreekLowercase(c)) 
                {
                    continue;
                }

                if (capitalizeNext)
                {
                    sb.Append(char.ToUpper(c));
                    capitalizeNext = false;
                }
                else
                {
                    sb.Append(c);
                }
            }
           
        }
        return sb.ToString();
    }

    private static bool IsGreekLowercase(char c)
    => (c >= '\u03B1' && c <= '\u03C9');
    
}