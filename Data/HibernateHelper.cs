namespace Data.DataAccessObject
{
  using Data.DataAccessObject;
  using Data.Util;
  using FluentNHibernate.Cfg;
  using FluentNHibernate.Cfg.Db;
  using NHibernate;
  using NHibernate.Cfg;
  using System.Reflection;

  /// <summary>
  /// NHibernate helper class
  /// </summary>
  public class HibernateHelper
  {
    /// <summary> Gets NHibernate session factory </summary>
    public static ISessionFactory SessionFactory
    {
      get;
      private set;
    }

    /// <summary>
    /// Public method to initialize session factory
    /// </summary>
    public static void StartSessionFactory()
    {
      InitializeSessionFactory();
    }

    /// <summary>
    /// Initializes configuring session factory
    /// </summary>
    private static void InitializeSessionFactory()
    {
      SessionFactory = Fluently.Configure()
          .Database(MsSqlConfiguration.MsSql2012
          .ConnectionString(ApplicationConfiguration.DatabaseConfiguration.ConnectionString))
          .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())
                        )
          .ExposeConfiguration(cfg => cfg.SetProperty(Environment.CurrentSessionContextClass, "web")
                                          .SetProperty(Environment.ShowSql, "true"))
          .BuildSessionFactory();
    }
  }
}
