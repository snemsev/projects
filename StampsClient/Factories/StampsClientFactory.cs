using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SCI = StampsClient.Interfaces;

namespace StampsClient
{
  public class StampsClientFactory
  {

    public static SCI.IMainWindowController CreateMainWindowController()
    {
      return new MainAppWindowController();
    }

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

  }
}
