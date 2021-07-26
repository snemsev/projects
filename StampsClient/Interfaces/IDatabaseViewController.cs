using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StampsClient.Interfaces {
  public interface IDatabaseViewController {
    void ConnectToView(IDataBaseView view);
    void SetModel(IDatabaseModel model);
  }
}
