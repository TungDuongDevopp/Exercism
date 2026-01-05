public static class PigLatin
{
    public static string TranslateWord(string word)
    {
        word = word.ToLower();

        // Rule 1
        if (StartsWithVowelSound(word))
            return word + "ay";

        int index = FirstVowelIndex(word);

        // Rule 3: qu
        if (index > 0 && word[index - 1] == 'q' && word[index] == 'u')
            index++;

        return word[index..] + word[..index] + "ay";
    }

    private static bool StartsWithVowelSound(string word)
    {
        return "aeiou".Contains(word[0]) ||
               word.StartsWith("xr") ||
               word.StartsWith("yt");
    }

    private static int FirstVowelIndex(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if ("aeiou".Contains(word[i]) || (word[i] == 'y' && i != 0))
                return i;
        }
        return word.Length;
    }
    public static string Translate(string input)
{
    string[] words = input.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
        words[i] = TranslateWord(words[i]);
    }

    return string.Join(" ", words);
}

}
