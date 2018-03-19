using System.Web.Http;

namespace TokenAuthAPI.Controllers
{
  public class APIController : ApiController
  {
    [Authorize(Roles = "user")]
    [Route("IsTokenAuthorized")]
    public IHttpActionResult Get()
    {
      return Ok("True");
    }
  }
}