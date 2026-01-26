using System.Text;
public static class Transpose
{
    public static string String(string input)
    {
        if (string.IsNullOrEmpty(input)) return "";

        var lines = input.Split('\n');
        int rows = lines.Length;
        int maxCols = lines.Max(l => l.Length);
        var result = new StringBuilder();

        for (int c = 0; c < maxCols; c++)
        {
            var lineBuilder = new StringBuilder();
            for (int r = 0; r < rows; r++)
            {
                // If the current column index exists in this row, append the char
                if (c < lines[r].Length)
                {
                    lineBuilder.Append(lines[r][c]);
                }
                else
                {
                  
                    bool hasMoreCharsInColumn = false;
                    for (int nextR = r + 1; nextR < rows; nextR++)
                    {
                        if (c < lines[nextR].Length)
                        {
                            hasMoreCharsInColumn = true;
                            break;
                        }
                    }

                    if (hasMoreCharsInColumn)
                        lineBuilder.Append(' ');
                    else
                        break; // No more characters in this column for any future rows
                }
            }
            
            result.Append(lineBuilder.ToString());
            if (c < maxCols - 1) result.Append('\n');
        }

        return result.ToString();
    }
}