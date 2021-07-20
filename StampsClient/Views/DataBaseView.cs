using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FORMS = System.Windows.Forms;

using SCI = StampsClient.Interfaces;

namespace StampsClient
{
    public partial class DataBaseView : FORMS.UserControl,
                                        SCI.IDataBaseView
    {

    #region IDataBaseView Implementation

    public FORMS.UserControl GetViewObject()
    {
      return this;
    }

    #endregion

    public DataBaseView()
        {
            InitializeComponent();
      this.Dock = FORMS.DockStyle.Fill;
        }
    }
}
