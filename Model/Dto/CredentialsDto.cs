using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto
{
  public class CredentialsDto : BaseModelDto
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="CredentialsDto" /> class.
    /// </summary>
    public CredentialsDto()
    {
    }

    /// <summary> Gets or sets the user's username </summary>
    public string Username { get; set; }

    /// <summary> Gets or sets the user's password </summary>
    public string Password { get; set; }
  }
}
