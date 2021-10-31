using System;
using System.Linq;
using Xunit;
 using EfEx.Domain;

namespace Assignment4.Tests
{
    public class DataServiceTests
    {
        public void Order_Object_HasIdDatesAndOrderDetails()
        {
            var order = new Order();
            Assert.Equal(0, order.Id);
            //Assert.Equal(new DateTime(), order.Date);
            //Assert.Equal(new DateTime(), order.Required);
            //Assert.Null(order.OrderDetails);
            Assert.Null(order.ShipName);
            Assert.Null(order.ShipCity);
        }
    }
}