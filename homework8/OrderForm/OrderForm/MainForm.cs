using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrderForm
{
    public partial class MainForm : Form
    {
        OrderService orderService;
        public String Keywords { get; set; }
        public event Action<EditForm> ShowEditForm;
        //TODO
        public MainForm()
        {
            InitializeComponent();
            ShowEditForm += (f => { });
            orderService = new OrderService();
            initOrders();
            OrdersBDS.DataSource = orderService.Orders;
            KeywordBOX.DataBindings.Add("Text", this, "Keyword");

        }

        private void initOrders()
        {
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1, new DateTime(2021, 3, 21));
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            //order1.AddDetails(new OrderDetail(eggs, 8));
            //order1.AddDetails(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2, new DateTime(2021, 3, 21));
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            Order order3 = new Order(3, customer2, new DateTime(2021, 3, 21));
            order3.AddDetails(new OrderDetail(milk, 100));

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
        }

        private void ExportBT_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }

        private void ImportBT_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                orderService.Import(fileName);
                QueryAll();
            }
        }
        public void QueryAll()
        {
            OrdersBDS.DataSource = orderService.Orders;
            OrdersBDS.ResetBindings(false);
        }

        private void CreateBT_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            ShowEditForm(editForm);

        }

        private void ReadBT_Click(object sender, EventArgs e)
        {

        }
    }
}
