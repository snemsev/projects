using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA = System.Data;
using FORMS = System.Windows.Forms;

namespace StampsClient.Interfaces
{
  public interface IDatabaseModel
  {

    string SourceFile { get; set; }

    FORMS.BindingSource DatabaseContents { get; }
  }
}
