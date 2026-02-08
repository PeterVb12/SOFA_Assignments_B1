namespace Bioscoop.Domain
{
    public class Movie
    {
        public string title {  get; set; }
        public Movie(string title)
        {
             this.title = title;
        }

        public void addScreen(MovieScreening screening)
        {
             
        }

        public override string ToString()
        {
            return title;
        }
    }
}