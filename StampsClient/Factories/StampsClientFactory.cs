using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SCI = StampsClient.Interfaces;

namespace StampsClient
{
  // Targeting the singleton pattern
  public class StampsClientFactory
  {
    #region Models

    public static SCI.IDatabaseModel CreateDatabaseModel() {
      return new DatabaseModel();
    }

    public static SCI.IStampsClientModel CreateStampsClientModel(){
      return new StampsClientModel();
    }

    #endregion


    #region Controllers

    public static SCI.IMainWindowController CreateMainWindowController()
    {
      return new MainAppWindowController();
    }

    public static SCI.IDatabaseViewController CreateDatabaseViewController() {
      return new DatabaseViewController();
    }

    #endregion


    #region Views

    public static SCI.IStampsClientAppView CreateStampsClientAppWindow()
    {
      return new MainAppWindow();
    }

    public static SCI.IDataBaseView CreateDatabaseView()
    {
      return new DataBaseView();
    }

    public static SCI.IStampsInterfaceView CreateStampsDotComView()
    {
      return new StampsInterfaceView();
    }

    #endregion

  }
}
