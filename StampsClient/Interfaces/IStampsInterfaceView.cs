using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FORMS = System.Windows.Forms;

namespace StampsClient.Interfaces
{
  public interface IStampsInterfaceView
  {
    FORMS.UserControl GetViewObject();
  }
}
