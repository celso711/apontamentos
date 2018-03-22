using Data.Repository;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
      try
      {
        UserRepository userRepository = new UserRepository();
       
      }
      catch (Exception ex)
      {

        throw;
      }
     
     
      UserSessionDto session = new UserSessionDto();

      //1- verifica se tem token
      //2- verifica se o token é valido: http://localhost:19647/IsTokenAuthorized
      //3 - se nao for valido pega um novo token: http://localhost:19647/token
      //  4- grava no banco para esse usuario o novo token
      //    5- verifica o token http://localhost:19647/IsTokenAuthorized
      // retorna okay logado

      var task = testAsync();
      task.Wait(); 
                  
      var result = task.Result;
    
      return session;
    }
    static async Task<object> testAsync()
    {
      var dict = new Dictionary<string, string>();
      dict.Add("grant_type", "password");
      dict.Add("username", "celso.neto");
      dict.Add("password", "#1q2w3e#");

      var req = new HttpRequestMessage(HttpMethod.Post, @"http://localhost:19647/token") { Content = new FormUrlEncodedContent(dict) };

      using (var httpClient = new HttpClient())
      {
        var httpResonse = await httpClient.SendAsync(req).ConfigureAwait(false);
        if (httpResonse.IsSuccessStatusCode)
        {
          var resp = await httpResonse.Content.ReadAsStringAsync().ConfigureAwait(false);
          return resp;
        }
      }
      return null;
    }
  }
}
