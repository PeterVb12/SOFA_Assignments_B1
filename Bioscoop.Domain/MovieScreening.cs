namespace Bioscoop.Domain
{
    public class MovieScreening
    {
        public DateTime dateAndTime {  get; set; }
        private double pricePerSeat;
        private Movie movie;

        public MovieScreening(Movie movie, DateTime dateAndTime, double pricePerSeat)
        {
            this.movie = movie;
            this.pricePerSeat = pricePerSeat;
            this.dateAndTime = dateAndTime;
        }

        public double getPricePerseat()
        {
            return pricePerSeat;
        }

        public string ToString()
        {
            return "screening for: " +  movie.ToString();
        }


    }
}