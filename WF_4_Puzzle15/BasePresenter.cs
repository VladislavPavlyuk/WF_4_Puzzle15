

using System.Windows.Forms;

namespace WF_4_Puzzle15
{
    public abstract class BasePresenter<T> : IPresenter<T> where T : IView
    {
        public T View { get; set; }
    }
}
