using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HuacalitosApi.Models;
using HuacalitosApi.Firebase;
using Firebase.Database;
using Firebase.Database.Query;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HuacalitosApi.Controllers
{
  [Route("api/[controller]")]
  public class ClientController : Controller
  {

    private readonly HuacalitosContext _context;

    public ClientController(HuacalitosContext context)
    {
      _context = context;

    }


    [HttpGet]
    public async Task<List<Client>> GetAllClientsAsync()
    {

      var client = new FirebaseConnection();
      var auth = await client.SignInWithEmailAndPasswordAsync(string.Empty, string.Empty);
      var firebase = new FirebaseClient("https://huacalitos-3b554.firebaseio.com",
        new FirebaseOptions
        {
          AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken)
        });

      var customers = await firebase.Child("customers").OrderByKey().OnceAsync<Client>();
      var CustomerData = new List<Client>();
      foreach (var item in customers)
      {
        CustomerData.Add(new Client
        {
          Id = long.Parse(item.Key),
          Email = item.Object.Email,
          Name = item.Object.Name
        });
      }

      return CustomerData;
      // return _context.Clients.ToList();
    }


    [HttpGet("{id}", Name = "GetClient")]
    public IActionResult GetClientById(long id)
    {
      var client = _context.Clients.FirstOrDefault(t => t.Id == id);
      if (client == null)
      {
        return NotFound();
      }
      return new ObjectResult(client);
    }

  }
}
