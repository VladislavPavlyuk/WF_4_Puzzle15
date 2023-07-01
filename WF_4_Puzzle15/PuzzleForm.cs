using System;
using System.Windows.Forms;

namespace WF_4_Puzzle15
{
    public partial class PuzzleForm : Form, IPuzzleView
    {
        public PuzzleForm()
        {
            InitializeComponent();
            UpdateGameLabels(false);
        }

        #region IPuzzleView implementation

        public string LabelTimer
        {
            get => labelTimer.Text;
            set => labelTimer.Text = value;
        }

        public string LabelMoves
        {
            get => labelMoves.Text;
            set => labelMoves.Text = value;
        }

        public TableLayoutControlCollection Buttons => tableLayoutPanelCellButtons.Controls;

        public event EventHandler NewGame;

        public event EventHandler Timer;

        public new event EventHandler Move;

        public event EventHandler BestScores;

        public void StartTimer()
        {
            timerGame.Enabled = true;
        }

        public void StopTimer()
        {
            timerGame.Enabled = false;
        }

        public void UpdateGameLabels(bool active)
        {
            labelTimer.Text = "00:00:00";
            labelTimer.Enabled = active;
            labelMoves.Text = "0";
            labelMoves.Enabled = active;
        }

        #endregion

        public void buttonCell_Click(object sender, EventArgs e)
        {
            Move?.Invoke(sender, EventArgs.Empty);
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            Timer?.Invoke(this, EventArgs.Empty);
        }

        public void NewGameHandler(object sender, EventArgs e)
        {
            NewGame?.Invoke(this, EventArgs.Empty);
        }

        private void BestScoresHandler(object sender, EventArgs e)
        {
            BestScores?.Invoke(this, EventArgs.Empty);
        }

        private void AboutHandler(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void ExitHandler(object sender, EventArgs e)
        {
            Close();
        }
    }
}
