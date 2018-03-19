using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataAccessObject
{
  public class HorasExtrasDao : BaseDao
  {
    /// <summary> Gets or sets </summary>
    public virtual string Inicio { get; set; }

    /// <summary> Gets or sets </summary>
    public virtual string Final { get; set; }

    /// <summary> Gets or sets </summary>
    public virtual string Total { get; set; }
  }
}
