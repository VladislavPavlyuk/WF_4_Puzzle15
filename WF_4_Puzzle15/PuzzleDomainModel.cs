

namespace WF_4_Puzzle15;

public class PuzzleDomainModel : IPuzzleDomainModel
{
    private readonly IPuzzle puzzle = new Puzzle();
    private readonly IBestScores bestScores = new BestScores();
    private readonly IBestScoresStorage bestScoresStorage = new BestScoresStorage(Options.BestScoresStorageFileName);

    #region IPuzzleDomainModel implementation

    public IPuzzle Puzzle => puzzle;
    public IBestScores BestScores => bestScores;
    public IBestScoresStorage BestScoresStorage => bestScoresStorage;

    #endregion
}
