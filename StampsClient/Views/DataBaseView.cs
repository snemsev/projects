using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FORMS = System.Windows.Forms;
using MODEL = System.ComponentModel;

using SCI = StampsClient.Interfaces;

namespace StampsClient {
  public partial class DataBaseView : FORMS.UserControl,
                                      SCI.IDataBaseView {

    #region Private Fields
    object _myLock;
    #endregion

    #region IDataBaseView Implementation

    public FORMS.UserControl GetViewObject() {
      return this;
    }

    public void SetDatabaseFileSource(MODEL.INotifyPropertyChanged bindingSource){
      lock (_myLock) {
        _databaseFileName.DataBindings.Add("Text", bindingSource, "SourceFile");
      }
    }

    public void RegisterForBrowseButtonClick(EventHandler clickHandler) {
      lock(_myLock){
        _browseButton.Click += clickHandler;
      }
    }

    public void UnregisterFromBrowseButtonClick(EventHandler clickHandler) {
      lock (_myLock) {
        _browseButton.Click -= clickHandler;
      }
    }

    public void SetDatabaseContentSource(FORMS.BindingSource bindingSource) {
      _databaseContents.DataSource = bindingSource;
    }

    #endregion


    public DataBaseView() {
      _myLock = new object();
      //  this.Dock = FORMS.DockStyle.Fill;
      
      InitializeComponent();
    }
  }
}
