﻿using Data.DataAccessObject;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
  public class ManhaMap : ClassMap<ManhaDao>
  {
    public ManhaMap()
    {
      this.Table("[Manha]");
      this.Id(x => x.Id).GeneratedBy.Identity();
    }
  }
}