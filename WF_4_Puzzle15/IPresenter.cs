using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_4_Puzzle15
{
    public interface IPresenter<T> where T : IView
    {
        T View { get; set; }
    }
}
