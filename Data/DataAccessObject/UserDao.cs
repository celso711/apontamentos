using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataAccessObject
{
  public class UserDao : BaseDao
  {
    public UserDao()
    {
    }

    /// <summary> Gets or sets user credential </summary>
    public virtual string Username { get; set; }

    /// <summary> Gets or sets the user's password </summary>
    public virtual string Password { get; set; }

    /// <summary> Gets or sets a value indicating whether user is active (when deleted, it's kept on the table, but the status is false) </summary>
    public virtual bool Active { get; set; }

    public virtual bool IsAdmin { get; set; }
  }
}
