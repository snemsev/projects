using StampsClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SCI = StampsClient.Interfaces;

namespace StampsClient {
  class StampsClientModel : SCI.IStampsClientModel {

    #region Private Fields

    object _myLock;
    SCI.IDatabaseModel _databaseModel;

    #endregion


    #region Constructors

    public StampsClientModel(){
      _myLock = new object();
      _databaseModel = StampsClientFactory.CreateDatabaseModel();
    }

    #endregion


    #region IStampsClientModel Implementation

    public SCI.IDatabaseModel DatabaseData {
      get {
        SCI.IDatabaseModel model;

        lock(_myLock){
          model = _databaseModel;
        }

        return model;
      }

      set {
        if(null == value){
          throw new ArgumentNullException(
            "DatabaseData.set: value is not allowed to be null.");
        }

        lock(_myLock){
          _databaseModel = value;
        }
      }
    }

    #endregion

  }
}
