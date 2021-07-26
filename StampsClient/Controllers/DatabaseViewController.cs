using StampsClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FORMS = System.Windows.Forms;
using MODEL = System.ComponentModel;

using SCI = StampsClient.Interfaces;


namespace StampsClient {
  class DatabaseViewController: SCI.IDatabaseViewController {

    #region Private Fields

    private object _myLock;
    private SCI.IDataBaseView _databaseView;
    private SCI.IDatabaseModel _model;

    #endregion


    #region Event Handlers

    private void BrowseButtonClicked(object sender, System.EventArgs e) {
      FORMS.OpenFileDialog fileBrowser = new FORMS.OpenFileDialog();

      if (fileBrowser.ShowDialog() == FORMS.DialogResult.OK) {
        _model.SourceFile = fileBrowser.FileName;
      }
    }

    #endregion

    #region Constructors

    public DatabaseViewController() {
      _myLock = new object();
      _model = StampsClientFactory.CreateDatabaseModel();
      _databaseView = StampsClientFactory.CreateDatabaseView();
    }

    #endregion

    #region IDatabaseViewController Implementation

    public void ConnectToView(IDataBaseView databaseView) {
      lock (_myLock) {
        if (null != databaseView) {
          _databaseView = databaseView;
        }
        else {
          _databaseView = StampsClientFactory.CreateDatabaseView();
        }

        MODEL.INotifyPropertyChanged dataSource =
          _model as MODEL.INotifyPropertyChanged;
        
        _databaseView.RegisterForBrowseButtonClick(BrowseButtonClicked);
        _databaseView.SetDatabaseFileSource(dataSource);
        _databaseView.SetDatabaseContentSource(_model.DatabaseContents);
        
      }
    }


    public void SetModel(IDatabaseModel model) {
      lock(_myLock){
        if (null != model) {
          _model = model;
        }
        else {
          _model = StampsClientFactory.CreateDatabaseModel();
        }
      }
    }

    #endregion
  }
}
