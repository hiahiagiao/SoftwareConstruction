using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            orderService.addOrder("1", "wang");
            orderService.addOrder("2", "hu");
            orderService.addOrder("1", "zheng");
            orderService.changeOrder("2", "cake", 2, 10);
            orderService.changeOrder("1", "cake", 3, 10);
            orderService.searchByCustomer("hu");
            
        }
    }
    public class Order :IComparable
    {
        public Order(string _id,string _customerName)
        {
            id = _id;
            customer = new Customer(_customerName);
        }
        private string id;
        private Customer customer;
        public List<OrderDetails> orderDetails = new List<OrderDetails>();
        public string Id
        {
            get
            {
                return id;
            }
        }
        public double Money
        {
            get
            {
                double money = 0;
                foreach (OrderDetails o in orderDetails)
                {
                    money += o.getTotalPrice();
                }
                return money;
            }
        }
        public string CustomerName
        {
            get
            {
                return customer.Name;
            }
        }
        public void show()
        {
            Console.WriteLine("id:" + Id);
            Console.WriteLine("customer's name:" + CustomerName);
            Console.WriteLine("Money:" + Money);
        }
        public override string ToString()
        {
            return id;
        }
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o.id==id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int CompareTo(object obj)
        {
            Order o = obj as Order;
            return id.CompareTo(o.id);
        }
        public void addOrderDetails(string name,int number, double price)
        {
            bool flag = false;
            foreach(OrderDetails o in orderDetails)
            {
                if (o.Name == name)
                {
                    o.Number += number;
                    flag = true;
                }
            }
            if (flag == false)
            {
                OrderDetails a = new OrderDetails(name, number, price);
                orderDetails.Add(a);
            }
        }
        public void removeOrderDetails(string name,int number)
        {
            bool flag = false;
            foreach(OrderDetails o in orderDetails)
            {
                if (o.Name == name)
                {
                    flag = true;
                    if (o.Number > number)
                    {
                        o.Number -= number;
                    }
                    else
                    {
                        orderDetails.Remove(o);
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("无该item");
                }
            }
        }
    }

    public class Customer
    {
        private string name;
        public string Name{
            get
            {
                return name;
            }
        }
        public Customer(string _name)
        {
            name = _name;
        }
        public override string ToString()
        {
            return name;
        }
    }
  
    public class OrderDetails
    {
        public OrderDetails(string _name, int _number,double _price)
        {
            name = _name;
            number = _number;
            price = _price;
        }
        public override string ToString()
        {
            return name;
        }
        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return od.name == name;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public double getTotalPrice()
        {
            return price * number;
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        public void export()
        {
            XmlSerializer a = new XmlSerializer(typeof(List<Order>));
            using (FileStream b = new FileStream("orders.xml", FileMode.Create))
            {
                a.Serialize(b, this.orders);
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
        public void addOrder(string id,string customerName)
        {
            orders.Add(new Order(id, customerName));
        }
        public void removeOrder(string id)
        {
            bool flag = false;
            foreach(Order o in orders)
            {
                if (o.Id == id)
                {
                    flag = true;
                    orders.Remove(o);
                }
            }
            if (flag == false)
            {
                Console.WriteLine("无该order");
            }
        }
        public void changeOrder(string id, string name,int number, double price)
        {
            bool flag = false;
            foreach (Order o in orders)
            {
                if (o.Id == id)
                {
                    flag = true;
                    o.addOrderDetails(name, number, price);
                }
            }
            if (flag == false)
            {
                Console.WriteLine("无该order");
            }
        }
        public void changeOrder(string id, string name, int number)
        {
            bool flag = false;
            foreach (Order o in orders)
            {
                if (o.Id == id)
                {
                    flag = true;
                    o.removeOrderDetails(name, number);
                }
            }
            if (flag == false)
            {
                Console.WriteLine("无该order");
            }
        }
        
        public void searchOrder(string searchType,string searchInfo)
        {
            switch (searchType)
            {
                case "id":
                    searchById(searchInfo);
                    break;
                case "customer":
                    searchByCustomer(searchInfo);
                    break;
            }
        }
        public void searchById(string id)
        {
            var query2 = from s2 in orders
                         where s2.CustomerName == id
                         orderby s2.Money
                         select s2;
            List<Order> a2 = query2.ToList();
            foreach (Order o in a2)
            {
                o.show();
            }
        }
        public void searchByCustomer(string cus)
        {
            var query1 = from s1 in orders
                         where s1.CustomerName == cus
                         orderby s1.Money
                         select s1;
            List<Order> a1 = query1.ToList();
            foreach(Order o in a1)
            {
                o.show();
            }
        }


    }

}
