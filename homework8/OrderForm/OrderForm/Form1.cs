using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class Form1 : Form
    {
        private OrderService orderService;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);

        }


        void Form1_Load(Object sender, EventArgs e)
        {
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            Order order3 = new Order(3, customer2);
            order3.AddDetails(new OrderDetail(milk, 100));


            orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            orderBindingSource.DataSource = orderService.orderList;
        }

        

        

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {

        }

        private void btn_query_Click(object sender, EventArgs e)
        {

        }
    }
}
