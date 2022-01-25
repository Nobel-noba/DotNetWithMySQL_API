using MongoDB.Driver;
using PracticeA.Models;
using System.Collections.Generic;
using System.Linq;

namespace PracticeA.Applications
{
    public class OrderServices
    {
        OrderContext orderContext;

        public OrderServices(OrderContext _orderContext)
        {
            orderContext = _orderContext;

        }

        /*  public OrderServices(OrderContext _orderContext)
          {
              this.orderContext = _orderContext;
          }*/
        public List<Orders> GetAllOrders()
        {
            return orderContext.Orders.ToList();
        }
        public Orders GetOrder(int id)
        {
            return orderContext.Orders.Find(id);
        }

        public void SetOrder(Orders order)
        {
            orderContext.Orders.Add(order);
            orderContext.SaveChanges();
        }

        public void UpdateOrder(int id,Orders order)
        {            var entity = orderContext.Orders.FirstOrDefault(e => e.Id == id);
            
                entity.Name = order.Name;
                entity.CName = order.CName;
        }
        public void RemoveOrder(int id)
        {
            var entity = orderContext.Orders.FirstOrDefault(o => o.Id == id);
            orderContext.Orders.Remove(entity);
            orderContext.SaveChanges();
        }
    }

}