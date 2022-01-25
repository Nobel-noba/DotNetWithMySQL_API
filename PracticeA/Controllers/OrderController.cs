using Microsoft.AspNetCore.Mvc;
using PracticeA.Applications;
using PracticeA.Models;
using System.Collections.Generic;

namespace PracticeA.Controllers
{
    [ApiController]
    [Route("api/mongo/Orders")]
    public class OrderController : ControllerBase
    {
        OrderServices orderService;

        public OrderController(OrderServices _orderService)
        {
            orderService = _orderService;
        }

        [HttpGet]
        public ActionResult<List<Orders>> GetAllOrders()
        {
            return orderService.GetAllOrders();
        }
        [HttpGet("{id:int}")]

        public ActionResult<Orders> GetOrder(int id)
        {
            return orderService.GetOrder(id);
        }

        [HttpPost]

        public ActionResult<Orders> SetOrder(Orders order)
        {
            orderService.SetOrder(order);
            return StatusCode(200);
        }

        [HttpPut("{id:int}")]

        public ActionResult<Orders> UpdateOrder(int id,Orders order)
        {
            orderService.UpdateOrder(id,order);
            return StatusCode(200);

        }

        [HttpDelete("{id:int}")]

        public ActionResult<Orders> RemoveOrder(int id)
        {
            orderService.RemoveOrder(id);
            return StatusCode(200);
        }
    }
}
