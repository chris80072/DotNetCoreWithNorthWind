using System.Linq;
using DotNetCoreWithNorthWind.Context;
using DotNetCoreWithNorthWind.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

[Route("api/[controller]s")]
public class OrderController : Controller
{
  private readonly OrderContext _orderContext;

  public OrderController(OrderContext context)
  {
    _orderContext = context;
  }

  [HttpGet("{id}")]
  public Order Get(int id)
  {
    // return Content(JsonConvert.SerializeObject(new { isSuccess = true, message = "Hello World" }), "application/json");
    var result = new Order();
    result = _orderContext.Orders.Where(o => o.OrderID.Equals(id)).FirstOrDefault();
    return result;
  }

  // [HttpGet]
  // public List<UserModel> Get(string q)
  // {
  //   // ...
  // }

  // [HttpGet("{id}")]
  // public UserModel Get(int id)
  // {
  //   // ...
  // }

  // [HttpPost]
  // public int Post([FromBody]UserModel user)
  // {
  //   // ...
  // }

  // [HttpPut("{id}")]
  // public void Put(int id, [FromBody]UserModel user)
  // {
  //   // ...
  // }

  // [HttpDelete("{id}")]
  // public void Delete(int id)
  // {
  //   // ...
  // }
}