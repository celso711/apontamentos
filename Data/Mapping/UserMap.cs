using Data.DataAccessObject;
using FluentNHibernate.Mapping;
using FluentNHibernate.MappingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
  public class UserMap : ClassMap<UserDao>
  {
    public UserMap()
    {
      this.Table("[User]");
      this.Id(x => x.Id).GeneratedBy.Identity();

    }

    protected UserMap(AttributeStore attributes, MappingProviderStore providers) : base(attributes, providers)
    {
    }
  }
}
