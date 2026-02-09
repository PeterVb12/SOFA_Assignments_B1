using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioscoop.Domain
{
    public class MovieTicket
    {
        private int rowNr { get; set; }
        private int seatNr { get; set; }
        private MovieScreening movieScreening;
        private bool isPremium { get; set; }

        public MovieTicket(MovieScreening movieScreening, bool isPremiumReservation, int seatRow, int seatNr)
        {
            this.movieScreening = movieScreening;
            isPremium = isPremiumReservation;
            this.seatNr = seatNr;
            rowNr = seatRow;

        }
        
        public Boolean IsPremiumTicket()
        {
            return isPremium;
        }

        public double getPrice()
        {

            return this.movieScreening.getPricePerseat();
            
        }

        public DateTime getScreeningTime()
        {
            return movieScreening.dateAndTime;
        }

        public string toString()
        {
            return "";
        }
    }
}
