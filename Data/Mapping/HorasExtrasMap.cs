﻿using Data.DataAccessObject;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
  public class HorasExtrasMap : ClassMap<HorasExtrasDao>
  {
    public HorasExtrasMap()
    {
      this.Table("[HORAS_EXTRAS]");
      this.Id(x => x.Id).GeneratedBy.Identity();
      this.Map(x => x.Final);
      this.Map(x => x.Inicio);
      this.Map(x => x.Total);
    }
  }
}
