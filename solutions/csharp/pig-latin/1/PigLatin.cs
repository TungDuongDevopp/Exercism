public static class PigLatin
{
    public static string Translate(string text)
    {
        var words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = TranslateWord(words[i]);
        }

        return string.Join(" ", words);
    }

    private static string TranslateWord(string word)
    {
        word = word.ToLower();

        if (isVowel(word[0]) || word.StartsWith("xr") || word.StartsWith("yt"))
            return word + "ay";

        int firstVowelIndex = -1;

        for (int i = 0; i < word.Length; i++)
        {
            if (isVowel(word[i]) || (word[i] == 'y' && i != 0))
            {
                firstVowelIndex = i;
                break;
            }

            if (word[i] == 'q' && i + 1 < word.Length && word[i + 1] == 'u')
            {
                firstVowelIndex = i + 2;
                break;
            }
        }

        return word[firstVowelIndex..] + word[..firstVowelIndex] + "ay";
    }

    private static bool isVowel(char c)
        => "aeiou".Contains(c);
}
