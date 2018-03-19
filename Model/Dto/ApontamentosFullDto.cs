using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
  public class ApontamentosFullDto : BaseModelDto
  {
    public ApontamentosFullDto()
    {
    }
    /// <summary> Gets or sets </summary>
    public string Data { get; set; }

    /// <summary> Gets or sets </summary>
    public string ManhaId { get; set; }

    /// <summary> Gets or sets </summary>
    public string TardeId { get; set; }

    /// <summary> Gets or sets </summary>
    public string HorasExtrasId { get; set; }

    /// <summary> Gets or sets </summary>
    public string HorasExtrasFdsId { get; set; }

    /// <summary> Gets or sets </summary>
    public string Resumo { get; set; }

  }
}
