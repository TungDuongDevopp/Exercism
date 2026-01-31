public static class ProteinTranslation
{
    private static readonly Dictionary<string, string> RNA = new()
    {
        ["AUG"] = "Methionine",
        ["UUU"] = "Phenylalanine", ["UUC"] = "Phenylalanine",
        ["UUA"] = "Leucine", ["UUG"] = "Leucine",
        ["UCU"] = "Serine", ["UCC"] = "Serine", ["UCA"] = "Serine", ["UCG"] = "Serine",
        ["UAU"] = "Tyrosine", ["UAC"] = "Tyrosine",
        ["UGU"] = "Cysteine", ["UGC"] = "Cysteine",
        ["UGG"] = "Tryptophan",
        ["UAA"] = "STOP", ["UAG"] = "STOP", ["UGA"] = "STOP"
    };

    public static string[] Proteins(string strand)
    {
        if (string.IsNullOrEmpty(strand))
            return Array.Empty<string>();

        strand = strand.ToUpper();
        var proteins = new List<string>();

        for (int i = 0; i + 2 < strand.Length; i += 3)
        {
            var codon = strand.Substring(i, 3);

            if (!RNA.TryGetValue(codon, out var protein))
                continue;

            if (protein == "STOP")
                break;

            proteins.Add(protein);
        }

        return proteins.ToArray();
    }
}
