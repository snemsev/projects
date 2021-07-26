using StampsClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FORMS = System.Windows.Forms;

using SCI = StampsClient.Interfaces;

namespace StampsClient
{
  public class MainAppWindowController : SCI.IMainWindowController
  {
    #region Private Fields
    object _myLock;

    SCI.IStampsClientAppView _appView;

    // TODO: StampsViewController
    SCI.IStampsInterfaceView _stampsInterfaceView;

    SCI.IDatabaseViewController _databaseViewController;
    SCI.IDataBaseView _databaseView;
    
    SCI.IStampsClientModel _stampsModel;

    // TODO: db view controller
    // TODO: stamps.com view controller
    #endregion

    #region Private Methods

    private void DatabaseViewButtonClicked(object sender, System.EventArgs e)
    {
      FORMS.UserControl dbView = _databaseView.GetViewObject();
      _appView.SetActiveView(dbView);
    }

    private void StampsDotComViewButtonClicked(object sender, System.EventArgs e)
    {
      FORMS.UserControl stampsDotComView = _stampsInterfaceView.GetViewObject();
      _appView.SetActiveView(stampsDotComView);
    }

    #endregion

    #region Constructors

    public MainAppWindowController()
    {
      _myLock = new object();
      _databaseViewController = StampsClientFactory.CreateDatabaseViewController();
      _stampsModel = StampsClientFactory.CreateStampsClientModel();
      _databaseViewController.SetModel(_stampsModel.DatabaseData);
      //TODO: StampsClientViewController
    }

    #endregion

    #region IMainWindowController Implementation

    public void ConnectToMainView(SCI.IStampsClientAppView stampsView)
    {

      if(null == stampsView)
      {
        throw new ArgumentNullException("stampsView is not allowed to be null.");
      }

      lock (_myLock)
      {
        _appView = stampsView;
        _appView.RegisterForDBInterfaceClick(DatabaseViewButtonClicked);
        _appView.RegisterForStampsClick(StampsDotComViewButtonClicked);
      }

    }

   public void ConnectToStampsView(SCI.IStampsInterfaceView stampsInterfaceView)
    {
      if (null == stampsInterfaceView)
      {
        throw new 
          ArgumentNullException("stampsInterfaceView is not allowed to be null.");
      }

      lock (_myLock)
      {
        _stampsInterfaceView = stampsInterfaceView;
        // TODO: Stamps controller
      }
    }

    public void ConnectToDatabaseView(SCI.IDataBaseView databaseView)
    {
      if (null == databaseView)
      {
        throw new
          ArgumentNullException("databaseView is not allowed to be null.");
      }

      lock (_myLock)
      {
        _databaseView = databaseView;
        _databaseViewController.ConnectToView(_databaseView);
      }
    }

    public void SetModel(SCI.IStampsClientModel model)
    {
      if (null == model)
      {
        throw new
          ArgumentNullException("model is not allowed to be null.");
      }

      lock (_myLock)
      {
        _stampsModel = model;
        _databaseViewController.SetModel(_stampsModel.DatabaseData);
        // TODO stamps interface model
      }
    }

    #endregion
  }
}
