using System.Windows.Forms;

namespace WF_4_Puzzle15;

public interface IBestScoresView : IView
{
    TableLayoutControlCollection Labels { get; }
}
