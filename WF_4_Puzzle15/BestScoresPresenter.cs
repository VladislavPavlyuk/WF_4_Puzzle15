
namespace WF_4_Puzzle15
{
    public class BestScoresPresenter : BasePresenter<IBestScoresView>
    {
        private IPuzzleDomainModel Model { get; set; }

        public BestScoresPresenter(IPuzzleDomainModel domainModel, IBestScoresView bestScoresView)
        {
            Model = domainModel;
            View = bestScoresView;

            UpdateView();
        }

        private void UpdateView()
        {
            try
            {
                Model.BestScoresStorage.Load(Model.BestScores);
            }
            catch
            {
                return;
            }

            foreach (Label label in View.Labels)
            {
                if (label.Name.StartsWith("nameLabel"))
                {
                    int index = int.Parse(label.Name.Remove(0, 9)) - 1;
                    if (index < Model.BestScores.Count)
                        label.Text = Model.BestScores[index].Name;
                }
                if (label.Name.StartsWith("movesLabel"))
                {
                    int index = int.Parse(label.Name.Remove(0, 10)) - 1;
                    if (index < Model.BestScores.Count)
                        label.Text =
                            Model.BestScores[index].Moves + " " +
                            Utils.GetMovesWord(Model.BestScores.Scores[index].Moves);
                }
                if (label.Name.StartsWith("timerLabel"))
                {
                    int index = int.Parse(label.Name.Remove(0, 10)) - 1;
                    if (index < Model.BestScores.Count)
                        label.Text = Model.BestScores[index].Timer.ToString(@"hh\:mm\:ss");
                }
            }
        }
    }
}
