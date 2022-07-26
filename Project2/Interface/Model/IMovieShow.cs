using Project1.Model;

namespace Project1.Interface.Model
{
    public interface IMovieShow
    {
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
