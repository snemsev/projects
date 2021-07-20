using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StampsClient.Interfaces
{
    public interface IMainWindowController
    {
        void ConnectToMainView(IStampsClientAppView stampsClientView);
        void ConnectToStampsView(IStampsInterfaceView stampsInterfaceView);
        void ConnectToDatabaseView(IDataBaseView databaseView);
        void SetModel(IStampsClientModel model);
    }
}
