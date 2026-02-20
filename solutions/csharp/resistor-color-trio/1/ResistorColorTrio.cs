using System;

public static class ResistorColorTrio
{
    private static readonly string[] code = 
        { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static string Label(string[] colors)
    {
        int first = Array.IndexOf(code, colors[0]);
        int second = Array.IndexOf(code, colors[1]);
        int zeros = Array.IndexOf(code, colors[2]);
        long value = (first * 10L + second) * (long)Math.Pow(10, zeros);
        return value switch
        {
            < 1_000 => $"{value} ohms",
            < 1_000_000 => $"{value / 1_000} kiloohms",
            < 1_000_000_000 => $"{value / 1_000_000} megaohms",
            _ => $"{value / 1_000_000_000} gigaohms"
        };
    }
}