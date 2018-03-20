using Business;
using Model.Dto;
using Model.Exception;
using Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class UserController : ApiController
    {
    [Route("login")]
    [HttpPost]
    public IHttpActionResult Login(CredentialsDto credentials)
    {
      try
      {
        UserSessionDto session = UserManager.Login(credentials);

        if (session != null)
        {
          return this.Ok(new HttpResultModel(true, string.Empty, session));
        }
        else
        {
          return this.Ok(new HttpResultModel(false, "Usuário ou senha inválidos"));
        }
      }
      catch (ApontamentoException e)
      {
        return this.Content(System.Net.HttpStatusCode.PreconditionFailed, new HttpResultModel(false, e.Message));
      }
      catch
      {
        return this.BadRequest("Não foi possível efetuar a operação");
      }
    }
  }
}
