namespace WF_4_Puzzle15;

public interface IPuzzleDomainModel
{
    IPuzzle Puzzle { get; }
    IBestScores BestScores { get; }
    IBestScoresStorage BestScoresStorage { get; }
}
