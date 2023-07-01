using System.Collections.Generic;

namespace WF_4_Puzzle15;

public interface IBestScores
{
    List<Score> Scores { get; }
    int Count { get; }
    Score this[int index] { get; set; }
    bool CanBeAdded(Score score);
    void Add(Score score);
}
