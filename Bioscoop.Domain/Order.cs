using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioscoop.Domain
{
    internal class Order
    {
        private int orderNr { get; set; }
        private bool isStudentOrder { get; set; }

        public Order(int orderNr, bool isStudentOrder)
        {
            this.orderNr = orderNr;
            this.isStudentOrder = isStudentOrder;
        }

        public int getOrderNr() 
        {  
            return orderNr; 
        }

        public void addSeatReservation(MovieTicket ticket)
        {

        }

        public double calculatePrice()
        {
            return 0;
        }

        public void export(TicketExportFormat exportFormat)
        {

        }
    }
}
