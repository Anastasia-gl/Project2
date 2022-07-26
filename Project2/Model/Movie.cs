using Project1.Interface.Model;
namespace Project1.Model
{
    public class Movie : IMovieShow
    {
        public Movie(string name, string description, int year, decimal rate, int genreId)
        {
            Name = name;
            Description = description;
            Year = year;
            Rate = rate;
            GenreId = genreId;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public decimal Rate { get; set; }

        public int GenreId { get; set; }

        public Genre Genres { get; set; }

        public IList<Cast> Сast { get; set; }
    }
}
