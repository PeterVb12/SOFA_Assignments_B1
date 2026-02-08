using Bioscoop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioscoop.Tests
{
    public class OrderTests
    {
        [Fact]
        public void Order_ShouldInitializeWithCorrectOrderNumber()
        {
            // Arrange
            int expectedOrderNr = 123;

            // Act
            Order order = new Order(expectedOrderNr, false);

            // Assert
            Assert.Equal(expectedOrderNr, order.getOrderNr());
        }
    }
}
