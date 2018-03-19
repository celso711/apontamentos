using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Util
{
  public class ApplicationConfiguration
  {
    /// <summary> Gets database connection configuration </summary>
    public static ConnectionStringSettings DatabaseConfiguration
    {
      get
      {
        return ConfigurationManager.ConnectionStrings["agendalab"];
      }
    }

    /// <summary> Gets Portal URL from config file </summary>
    public static string PortalUrl
    {
      get
      {
        return ConfigurationManager.AppSettings["PortalUrl"];
      }
    }

    /// <summary> Gets the quantity results per page </summary>
    public static byte ResultsPerPage
    {
      get
      {
        return Convert.ToByte(ConfigurationManager.AppSettings["ResultsPerPage"]);
      }
    }
  }
}
