using System;
using System.Collections.Generic;



using FORMS = System.Windows.Forms;

using SCI = StampsClient.Interfaces;

namespace StampsClient
{
  public partial class MainAppWindow : FORMS.Form,
                                       SCI.IStampsClientAppView
  {
    public MainAppWindow()
    {
      InitializeComponent();
    }

    public void RegisterForDBInterfaceClick(EventHandler clickHandler)
    {
      _dbInterfaceBtn.Click += clickHandler;
    }

    public void RegisterForStampsClick(EventHandler clickHandler)
    {
      _stampsBtn.Click += clickHandler;
    }

    public void UnregisterFromForDBInterfaceClick(EventHandler clickHandler)
    {
      _dbInterfaceBtn.Click -= clickHandler;
    }

    public void UnregisterFromStampsClick(EventHandler clickHandler)
    {
      _stampsBtn.Click -= clickHandler;
    }

    public void SetActiveView(FORMS.UserControl view)
    {
      _applicationGrid.Panel2.Controls.Clear();
      _applicationGrid.Panel2.Controls.Add(view);
    }

    public FORMS.Form GetViewObject()
    {
      return this;
    }
  }
}
