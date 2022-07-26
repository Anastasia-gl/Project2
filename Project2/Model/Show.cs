using Project1.Interface.Model;

namespace Project1.Model
{
    public class Show: IMovieShow
    {
        public Show(string name, string description, int year, decimal rate, int genreId, int numberSeasons)
        {
            Name = name;
            Description = description;
            Year = year;
            Rate = rate;
            GenreId = genreId;
            NumberSeasons = numberSeasons;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public decimal Rate { get; set; }

        public int GenreId { get; set; }

        public int NumberSeasons { get; set; }

        public Genre Genres { get; set; }

        public IList<Cast> Сast { get; set; }
    }
}
