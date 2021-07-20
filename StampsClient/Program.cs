using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using SCI = StampsClient.Interfaces;

namespace StampsClient
{
    static class Program
    {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        SCI.IMainWindowController controller =
          StampsClientFactory.CreateMainWindowController();

        SCI.IStampsClientAppView mainView =
          StampsClientFactory.CreateStampsClientAppWindow();

        SCI.IStampsInterfaceView stampsDotComView =
          StampsClientFactory.CreateStampsDotComView();

        SCI.IDataBaseView databaseView =
          StampsClientFactory.CreateDatabaseView();

        controller.ConnectToMainView(mainView);
        controller.ConnectToDatabaseView(databaseView);
        controller.ConnectToStampsView(stampsDotComView);

        
        Application.Run(mainView.GetViewObject());
      }
    }
}
