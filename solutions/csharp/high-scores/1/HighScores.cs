public class HighScores
{
    private readonly List<int> _highScores;

    public HighScores(List<int> list)
    {
        _highScores = new List<int>(list);
    }

    public List<int> Scores()
        => new List<int>(_highScores);

    public int Latest()
        => _highScores[^1];

    public int PersonalBest()
        => _highScores.Max();

    public List<int> PersonalTopThree()
        => _highScores
            .OrderByDescending(x => x)
            .Take(3)
            .ToList();
}