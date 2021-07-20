
using System;
using FORMS = System.Windows.Forms;

using SCI = StampsClient.Interfaces;

namespace StampsClient
{
  public partial class StampsInterfaceView : FORMS.UserControl,
                                             SCI.IStampsInterfaceView
  {
    #region IDataBaseView Implementation

    public FORMS.UserControl GetViewObject()
    {
      return this;
    }

    #endregion
    public StampsInterfaceView()
    {
        InitializeComponent();
      this.Dock = FORMS.DockStyle.Fill;
    }
  }
}
