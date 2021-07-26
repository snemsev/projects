using System;
using System.Collections.Generic;
using DATA = System.Data;
using DB = System.Data.OleDb;
using FORMS = System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCI = StampsClient.Interfaces;
using MODEL = System.ComponentModel;

namespace StampsClient {
  class DatabaseModel : SCI.IDatabaseModel, MODEL.INotifyPropertyChanged {

    #region Private Fields

    private object _myLock;
    private FORMS.BindingSource _data;
    private string _sourceFile;

    #endregion


    #region Private Methods

    DATA.DataTable GetDatabaseContents(string file){
      DATA.DataTable extractedTable = new DATA.DataTable();

      //string connectString =
      //  @"Provider=Microsoft.JET.OLEDB.4.0;Data source=" + file;

      string connectString =
       @"Provider=Microsoft.ACE.OLEDB.12.0;data source=" + file;

      string query = "SELECT * FROM Orders;";
      
      using(DB.OleDbConnection dbConnection =
            new DB.OleDbConnection(connectString)) {

        DB.OleDbCommand fetchDataCommand = new DB.OleDbCommand(query, dbConnection);

        try{
          dbConnection.Open();
          DATA.DataTable tables = dbConnection.GetOleDbSchemaTable(DB.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE"});
          DB.OleDbDataAdapter dbAdapter = new DB.OleDbDataAdapter(fetchDataCommand);
          dbAdapter.Fill(extractedTable);
        }
        catch (Exception e){
          // TODO
        }

      }

      return extractedTable;
    }

    #endregion


    #region Constructors

    public DatabaseModel(){
      _myLock = new object();
      _data = new FORMS.BindingSource();
      _sourceFile = string.Empty;
    }

    #endregion


    #region IDatabaseModel Implementation

    public FORMS.BindingSource DatabaseContents {
      get {
        FORMS.BindingSource data;
        lock (_myLock) {
          // TODO: fetch data.
          data = _data;
        }
        return data;
      }

      private set{
        lock(_myLock){
          _data = value;
        }

        InvokePropertyChanged(
          new MODEL.PropertyChangedEventArgs("DatabaseContents"));
      }
    }

    public string SourceFile {
      get {
        string file = string.Empty;

        lock(_myLock){
          file = _sourceFile;
        }

        return file;
      }

      set{
        lock(_myLock){
          _sourceFile = value;
          DatabaseContents.DataSource = GetDatabaseContents(_sourceFile);
         
        }

        InvokePropertyChanged(new MODEL.PropertyChangedEventArgs("SourceFile"));
      }
    }

    #endregion


    #region INotifyPropertyChanged Implementation

    public event MODEL.PropertyChangedEventHandler PropertyChanged;

    public void InvokePropertyChanged(MODEL.PropertyChangedEventArgs e) {
      MODEL.PropertyChangedEventHandler handler = PropertyChanged;
      if (null != handler) {
        handler(this, e);
      }
    }

    #endregion

  }
}
