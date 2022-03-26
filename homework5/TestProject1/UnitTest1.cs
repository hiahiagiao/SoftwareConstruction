using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderControl;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        OrderService service = new OrderService();
        [TestMethod]
        public void testAddOrder()
        {
            service.addOrder("", "");
            service.addOrder("天字一号", "Alan");
            service.addOrder("1", "wang");
            service.addOrder("2", "hu");
            service.addOrder("1", "zheng");
            Assert.AreEqual(service.orders.Count, 5);
        }
        [TestMethod]
        public void testRemoveOrder()
        {
            service.addOrder("", "");
            service.addOrder("天字一号", "Alan");
            service.addOrder("1", "wang");
            service.addOrder("2", "hu");
            service.addOrder("1", "zheng");
            service.removeOrder("天字一号");
            Assert.AreEqual(service.orders.Count, 4);
        }
        [TestMethod]
        public void testRemoveInvaildOrder()
        {
            service.addOrder("", "");
            service.addOrder("天字一号", "Alan");
            service.addOrder("1", "wang");
            service.addOrder("2", "hu");
            service.addOrder("1", "zheng");
            service.removeOrder("天字一");
            Assert.AreEqual(service.orders.Count, 5);
        }
        [TestMethod]
        public void testAddOrderDetail()
        {
            service.addOrder("天字一号", "Alan");
            service.changeOrder("天字一号", "cake", 2, 10);
            Assert.AreEqual(service.orders[0].Money, 20);
        }
        public void testRemoveOrderDetail()
        {
            service.addOrder("天字一号", "Alan");
            service.changeOrder("天字一号", "cake", 2, 10);
            service.changeOrder("天字一号", "cake", 2, 10);
            service.changeOrder("天字一号", "beer", 2, 10);
            service.changeOrder("天字一号", "cake", 1);
            Assert.AreEqual(service.orders[0].Money,50);
        }
        public void testSearch()
        {

            service.addOrder("", "");
            service.addOrder("天字一号", "Alan");
            service.addOrder("1", "wang");
            service.addOrder("2", "hu");
            service.addOrder("1", "zheng");
            service.searchOrder("id", "天字一号");
            service.searchOrder("customer", "alan");
            service.searchOrder("customer", "Alan");
        }

    }
}
