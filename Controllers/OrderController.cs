using System.Collections.Generic;
using System.Linq;
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
  public ActionResult Get(int id)
  {
    var order = _orderService.Get(id);
    return Content(JsonConvert.SerializeObject(new { IsSuccess = true, Order = order }), "application/json");
  }

  [HttpPost]
  public ActionResult Post([FromBody]Order order)
  {
    var orderID = _orderService.Create(order);
    var isSuccess = orderID > 0 ? true : false;
    return Content(JsonConvert.SerializeObject(new { IsSuccess = isSuccess, OrderID = orderID }), "application/json");
  }

  [HttpPut("{id}")]
  public ActionResult Put([FromBody]Order order)
  {
    var isSuccess = _orderService.Update(order);
    return Content(JsonConvert.SerializeObject(new { IsSuccess = isSuccess }), "application/json");
  }

  [HttpDelete("{id}")]
  public ActionResult Delete(int id)
  {
    var isSuccess = _orderService.Delete(id);
    return Content(JsonConvert.SerializeObject(new { IsSuccess = isSuccess }), "application/json");
  }
}