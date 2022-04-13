using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OrderForm

{
    public class OrderService
    {
        public List<Order> orderList = new List<Order>();

        public OrderService()
        {
        }
        public void export()
        {
            XmlSerializer a = new XmlSerializer(typeof(List<Order>));
            using (FileStream b = new FileStream("orders.xml", FileMode.Create))
            {
                a.Serialize(b, this.orderList);
            }
            Console.WriteLine("序列化完成");
        }
        public void import()
        {
            try
            {
                XmlSerializer a = new XmlSerializer(typeof(List<Order>));
                using (FileStream b = new FileStream("orders.xml", FileMode.Open))
                {
                    List<Order> c = (List<Order>)a.Deserialize(b);
                }
            }
            catch
            {
                Console.WriteLine("序列化系列操作错误");
            }
        }
        public void AddOrder(Order order)
        {
            if (order == null || !order.IsValid())
            {
                throw new ApplicationException($"Invalid order!");
            }
            if (orderList.Contains(order))
            {
                throw new ApplicationException($"the order {order.Id} already exists!");
            }
            orderList.Add(order);
        }

        public void Update(Order order)
        {
            if (order == null || !order.IsValid())
            {
                throw new ApplicationException($"Invalid order!");
            }
            Order orderInList = GetById(order.Id);
            if (orderInList == null)
            {
                throw new ApplicationException($"the order {order.Id} does not exist!");
            }
            orderList.Remove(orderInList);
            orderList.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            orderList.RemoveAll(o => o.Id == orderId);
        }

        public Order GetById(int orderId)
        {
            return orderList.Where(o => o.Id == orderId).FirstOrDefault();
        }

        public List<Order> QueryAll()
        {
            return orderList.OrderBy(o => o.TotalAmount).ToList<Order>();
        }

        public List<Order> QueryByGoodsName(string goodsName)
        {
            var query = orderList
              .Where(o => o.Details.Any(d => d.Goods.Name == goodsName))
              .OrderBy(o => o.TotalAmount);
            return query.ToList();
        }

        public List<Order> QueryByTotalAmount(float totalAmount)
        {
            var query = orderList
              .Where(o => o.TotalAmount >= totalAmount)
              .OrderBy(o => o.TotalAmount);
            return query.ToList();
        }

        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orderList
                .Where(o => o.Customer.Name == customerName)
                .OrderBy(o => o.TotalAmount);
            return query.ToList();
        }

        public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            return orderList
              .Where(o => condition(o))
              .OrderBy(o => o.TotalAmount);
        }

        public void Sort(Comparison<Order> comparison)
        {
            orderList.Sort(comparison);
        }
    }
}
