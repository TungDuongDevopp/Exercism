using System.Collections.Generic;

public static class BottleSong
{
    private static readonly string[] read =
    {
        "No","One","Two","Three","Four","Five",
        "Six","Seven","Eight","Nine","Ten"
    };
    private static string Bottle(int n) => n == 1 ? "bottle" : "bottles";
 public static IEnumerable<string> Recite(int startBottles, int takeDown)
{
    int current = startBottles;

    for (int i = 0; i < takeDown; i++)
    {
        int next = current - 1;

        yield return $"{read[current]} green {Bottle(current)} hanging on the wall,";
        yield return $"{read[current]} green {Bottle(current)} hanging on the wall,";
        yield return "And if one green bottle should accidentally fall,";
        yield return $"There'll be {read[next].ToLower()} green {Bottle(next)} hanging on the wall.";

        if (i < takeDown - 1)
            yield return "";

        current--;
    }
}

}

