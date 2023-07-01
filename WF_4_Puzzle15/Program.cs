namespace WF_4_Puzzle15
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
          
            var puzzlePresenter = new PuzzlePresenter(new PuzzleDomainModel(), new PuzzleForm());
            Application.Run((Form)puzzlePresenter.View);
        }
    }
}