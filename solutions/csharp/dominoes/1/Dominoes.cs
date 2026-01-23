public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var list = dominoes.ToList();

        if (list.Count == 0)
            return true;

        var used = new bool[list.Count];

        // thử từng domino làm điểm bắt đầu
        for (int i = 0; i < list.Count; i++)
        {
            used[i] = true;

            var (a, b) = list[i];

            // thử hướng a -> b
            if (Backtrack(list, used, b, a, 1))
                return true;

            // thử hướng b -> a
            if (Backtrack(list, used, a, b, 1))
                return true;

            used[i] = false;
        }

        return false;
    }
    private static bool Backtrack(
        List<(int, int)> dominoes,
        bool[] used,
        int start,
        int prevEnd,
        int count)
    {
        // dùng hết domino → kiểm tra vòng kín
        if (count == dominoes.Count)
            return prevEnd == start;

        for (int i = 0; i < dominoes.Count; i++)
        {
            if (used[i]) continue;

            var (a, b) = dominoes[i];

            // hướng a -> b
            if (a == prevEnd)
            {
                used[i] = true;
                if (Backtrack(dominoes, used, start, b, count + 1))
                    return true;
                used[i] = false;
            }

            // hướng b -> a
            if (b == prevEnd)
            {
                used[i] = true;
                if (Backtrack(dominoes, used, start, a, count + 1))
                    return true;
                used[i] = false;
            }
        }

        return false;
    }
}
