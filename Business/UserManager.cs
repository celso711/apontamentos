using Data.Repository;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
  public class Product
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
  }
  public static class UserManager
  {

    static HttpClient client = new HttpClient();

    public static UserSessionDto Login(CredentialsDto credentials)
    {
      UserRepository userRepository = new UserRepository();

      UserSessionDto session = new UserSessionDto();
      CreateProductAsync();
      return session;
    }

    static async Task<Uri> CreateProductAsync()
    {

      var client = new HttpClient();
      client.BaseAddress = new Uri("http://localhost:19647");
      var request = new HttpRequestMessage(HttpMethod.Post, "token");

      var requestContent = string.Format("site={0}&content={1}", Uri.EscapeDataString("http://localhost:19647"),
          Uri.EscapeDataString("grant_type=password&username=celso.neto&password=%231q2w3e%23"));
      request.Content = new StringContent(requestContent, Encoding.UTF8, "application/x-www-form-urlencoded");

      var response = await client.SendAsync(request);

      return null;
    }

  }
}
