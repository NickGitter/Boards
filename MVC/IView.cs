using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutBoards.MVC
{
    interface IView
    {
        void UpdateView(object dataFromModel, object dataOnView);
        void ControllerCalculate(List<double> data, IController controller);

    }
}
