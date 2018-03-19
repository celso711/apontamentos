using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataAccessObject
{
  public class ApontamentosDao : BaseDao
  {
    /// <summary> Gets or sets </summary>
    public virtual string Data { get; set; }

    /// <summary> Gets or sets </summary>
    public virtual string Final { get; set; }

    /// <summary> Gets or sets </summary>
    public virtual int ManhaId { get; set; }

    /// <summary> Gets or sets </summary>
    public virtual int HorasExtrasId { get; set; }

    /// <summary> Gets or sets </summary>
    public virtual int TardeId { get; set; }

    /// <summary> Gets or sets </summary>
    public virtual int HorasExtrasFdsId { get; set; }

    /// <summary> Gets or sets </summary>
    public virtual string Resumo { get; set; }
  }
}
