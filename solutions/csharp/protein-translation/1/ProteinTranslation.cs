public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        strand = strand.ToUpper();
        List<string> list = new List<string>();

        Dictionary<string, string> codonTable = new Dictionary<string, string>
        {
            {"AUG","Methionine"},
            {"UUU","Phenylalanine"},{"UUC","Phenylalanine"},
            {"UUA","Leucine"},{"UUG","Leucine"},
            {"UCU","Serine"},{"UCC","Serine"},{"UCA","Serine"},{"UCG","Serine"},
            {"UAU","Tyrosine"},{"UAC","Tyrosine"},
            {"UGU","Cysteine"},{"UGC","Cysteine"},
            {"UGG","Tryptophan"},
            {"UAA","STOP"},{"UAG","STOP"},{"UGA","STOP"}
        };

        for (int i = 0; i <= strand.Length - 3; i += 3)
        {
            string rna = strand.Substring(i, 3);

            if (!codonTable.ContainsKey(rna))
                throw new ArgumentException("Invalid codon");

            if (codonTable[rna] == "STOP")
                break;

            list.Add(codonTable[rna]);
        }

        return list.ToArray();
    }
}
