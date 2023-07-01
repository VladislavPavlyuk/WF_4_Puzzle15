using System.Windows.Forms;

namespace WF_4_Puzzle15
{
    public partial class BestScoresForm : Form, IBestScoresView
    {
        public BestScoresForm()
        {
            InitializeComponent();
        }

        #region IBestScoresView implementation

        public TableLayoutControlCollection Labels => tableLayoutPanelLabels.Controls;

        #endregion
    }
}
