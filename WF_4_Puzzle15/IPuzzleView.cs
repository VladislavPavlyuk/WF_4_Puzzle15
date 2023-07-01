using System;
using System.Windows.Forms;

namespace WF_4_Puzzle15;

public interface IPuzzleView : IView
{
    string LabelTimer { get; set; }
    string LabelMoves { get; set; }
    TableLayoutControlCollection Buttons { get; }

    event EventHandler NewGame;
    event EventHandler Timer;
    event EventHandler Move;
    event EventHandler BestScores;

    void StartTimer();
    void StopTimer();
    void UpdateGameLabels(bool active);
}
