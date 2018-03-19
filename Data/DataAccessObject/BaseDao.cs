using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataAccessObject
{
  public class BaseDao
  {
    /// <summary> Gets or sets the DAO's Id </summary>
    public virtual int? Id { get; set; }
  }
}
