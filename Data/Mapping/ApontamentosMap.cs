using Data.DataAccessObject;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
  public class ApontamentosMap : ClassMap<ApontamentosDao>
  {
    public ApontamentosMap()
    {
      this.Table("[APONTAMENTOS]");
      this.Id(x => x.Id).GeneratedBy.Identity();
      this.Map(x => x.Data);
      this.References(x => x.HorasExtrasFdsId, "HORAS_EXTRAS_FDS_ID");
      this.References(x => x.HorasExtrasId, "HORAS_EXTRAS_ID");
      this.References(x => x.ManhaId, "MANHA_ID");
      this.References(x => x.TardeId, "TARDE_ID");
      this.Map(x => x.Resumo);

    }
  }
}
