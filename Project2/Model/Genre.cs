namespace Project1.Model
{
    public class Genre
    {
        public Genre(string title)
        {
            Title = title;
        }

        public int GenreId { get; set; }

        public string Title { get; set; }

        public IList<Movie> Movie { get; set; }

        public IList<Show> Show { get; set; }
    }
}
