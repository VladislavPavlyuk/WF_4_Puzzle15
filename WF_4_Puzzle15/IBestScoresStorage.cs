namespace WF_4_Puzzle15;

public interface IBestScoresStorage
{
    string FileName { get; set; }
    void Save(IBestScores bestScores);
    void Load(IBestScores bestScores);
}
