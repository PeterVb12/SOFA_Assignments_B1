using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioscoop.Domain
{
    public class Order
    {
        private int orderNr { get; set; }
        private bool isStudentOrder { get; set; }
        private List<MovieTicket> tickets = new List<MovieTicket>();

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
            this.tickets.Add(ticket);
        }

        public double calculatePrice()
        {
            double totalPrice = 0;

            if (isStudentOrder)
            {
                for (int i = 0; i < tickets.Count; i++)
                {   
                    MovieTicket ticket = tickets[i];
                    double ticketPrice = ticket.getPrice();

                    if (ticket.IsPremiumTicket())
                    {
                        ticketPrice += 2.0;
                    }

                    if ((i + 1) % 2 == 0) 
                    {
                        ticketPrice = 0;
                    }

                    totalPrice += ticketPrice;
                }
            }
            else 
            {
                bool isDoordeweeks = isDoorDeWeeks();

                for (int i = 0; i < tickets.Count; i++)
                {
                    MovieTicket ticket = tickets[i];
                    double ticketPrice = ticket.getPrice();

                    if (ticket.IsPremiumTicket())
                    {
                        ticketPrice += 3.0;
                    }

                    if (isDoordeweeks && (i + 1) % 2 == 0)
                    {
                        ticketPrice = 0;
                    }

                    totalPrice += ticketPrice;
                }

                // Weekend groepskorting: 10% bij 6+ tickets
                if (!isDoordeweeks && tickets.Count >= 6)
                {
                    totalPrice *= 0.9; // 10% korting
                }
            }

            return totalPrice;

        }

        public bool isDoorDeWeeks()
        {
            DayOfWeek day = tickets[0].getScreeningTime().DayOfWeek;

            return day != DayOfWeek.Saturday && day != DayOfWeek.Sunday && day != DayOfWeek.Friday;

        }

        public void export(TicketExportFormat exportFormat)
        {

        }
    }
}
