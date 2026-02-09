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

        //Studenten order met 1 premium ticket met een stoel van 10 euro, verwacht bedrag wat eruit komt is 12 euro
        [Fact]
        public void Order_StudentOrderOnePremiumTicket()
        {
            // Arrange
            Movie inception = new Movie("Inception");
            MovieScreening inception1 = new MovieScreening(inception, new DateTime(2025, 2, 9), 10.0);
            MovieTicket ticket1 = new MovieTicket(inception1, true, 1, 1);
            Order order = new Order(1, true);
            order.addSeatReservation(ticket1);

            double expectedPrice = 12.0;

            // Act
            double actualPrice = order.calculatePrice();

            // Assert
            Assert.Equal(expectedPrice, actualPrice);
        }
    }
}
