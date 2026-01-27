using System.Text;
public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var sb = new StringBuilder();
        int count = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (i + 1 < input.Length && input[i] == input[i + 1])
            {
                count++;
            }
            else
            {
                if (count > 1)
                    sb.Append(count);

                sb.Append(input[i]);
                count = 1;
            }
        }

        return sb.ToString();
    }
     public static string Decode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var sb = new StringBuilder();
        int count = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                count = count * 10 + (c - '0'); // xử lý số nhiều chữ số
            }
            else
            {
                int repeat = count == 0 ? 1 : count;

                for (int i = 0; i < repeat; i++)
                    sb.Append(c);

                count = 0;
            }
        }

        return sb.ToString();
    }
}