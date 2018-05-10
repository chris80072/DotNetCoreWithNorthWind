using System.Collections.Generic;
using System.Linq;
using DotNetCoreWithNorthWind.Contexts;
using DotNetCoreWithNorthWind.Models;
using DotNetCoreWithNorthWind.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

[Route("api/[controller]s")]
public class OrderController : Controller
{
  private readonly IOrderService _orderService;

  public OrderController(IOrderService orderService)
  {
      _orderService = orderService;
  }

  [HttpGet("{id}")]
  public Order Get(int id)
  {
    return _orderService.Get(id);
  }

  // [HttpGet]
  // public List<Order> Get()
  // {
  //   return _orderContext.Orders.ToList();
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