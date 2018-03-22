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
      this.Map(x => x.AccessToken);
      this.Map(x => x.Active);
      this.Map(x => x.IsAdmin);
      this.Map(x => x.Password);
      this.Map(x => x.Username);
    }

    protected UserMap(AttributeStore attributes, MappingProviderStore providers) : base(attributes, providers)
    {
    }
  }
}
