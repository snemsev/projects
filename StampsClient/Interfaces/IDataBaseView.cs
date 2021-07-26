using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DATA = System.Data;
using FORMS = System.Windows.Forms;
using MODEL = System.ComponentModel;

namespace StampsClient.Interfaces
{
  public interface IDataBaseView
  {
    void SetDatabaseFileSource(MODEL.INotifyPropertyChanged fileNameSource);
    void SetDatabaseContentSource(FORMS.BindingSource bindingSource);
    void RegisterForBrowseButtonClick(EventHandler clickHandler);
    void UnregisterFromBrowseButtonClick(EventHandler clickHandler);
    FORMS.UserControl GetViewObject();
  }
}
