using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
  public class UserSessionDto : BaseModelDto
  {
    public UserSessionDto()
    {
    }

    /// <summary> Gets or sets user credential </summary>
    public string Username { get; set; }

    /// <summary> Gets or sets user name </summary>
    public string Name { get; set; }

    /// <summary> Gets or sets the user's profile Id </summary>
    public int? IdProfile { get; set; }

    /// <summary> Gets or sets the user's profile name </summary>
    public string ProfileName { get; set; }

    /// <summary> Gets or sets the access token </summary>
    public string AccessToken { get; set; }

  }
}
