using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FORMS = System.Windows.Forms;

namespace StampsClient.Interfaces
{
  public interface IStampsClientAppView
  {
    void RegisterForDBInterfaceClick(EventHandler clickHandler);

    void UnregisterFromForDBInterfaceClick(EventHandler clickHandler);

    void RegisterForStampsClick(EventHandler clickHandler);

    void UnregisterFromStampsClick(EventHandler clickHandler);

    void SetActiveView(FORMS.UserControl view);

    FORMS.Form GetViewObject();
  }
}
