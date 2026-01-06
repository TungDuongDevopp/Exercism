using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();
        bool makeUpper = false;

        foreach (char c in identifier)
        {
            // khoảng trắng -> _
            if (char.IsWhiteSpace(c))
            {
                sb.Append('_');
                makeUpper = false;
            }
            // ký tự điều khiển
            else if (char.IsControl(c))
            {
                sb.Append("CTRL");
                makeUpper = false;
            }
            // dấu gạch ngang: kích hoạt camelCase
            else if (c == '-')
            {
                makeUpper = true;
            }
            // bỏ chữ hoa Hy Lạp
            else if (IsLowercaseGreek(c))
            {
                makeUpper = false;
                continue;
            }
            // bỏ ký tự không phải chữ
            else if (!char.IsLetter(c))
            {
                makeUpper = false;
                continue;
            }
            else
            {
                if (makeUpper)
                {
                    sb.Append(char.ToUpper(c));
                    makeUpper = false;
                }
                else
                {
                    sb.Append(c);
                }
            }
        }

        return sb.ToString();
    }

    private static bool IsLowercaseGreek(char c)
    {
        return c >= '\u0370' && c <= '\u03FF' && char.IsLower(c);
    }
}
