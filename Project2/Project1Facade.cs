using Project1.Service;
using Project1.Model;
namespace Project1
{
    public class Project1Facade
    {
        private readonly AppContext _appContext;
        private readonly EntityService<Producer> _producerEntity;
        private readonly EntityService<Actor> _actorEntity;
        private readonly GenreStore _genreStore;
        private readonly MovieStore _movieStore;
        private readonly ShowStore _showStore;
        private readonly ActorStore _actorStore;
        private readonly ProducerStore _producerStore;
        private readonly WatchService<Movie> _watchServieMovie;
        private readonly WatchService<Show> _watchServieShow;

        public Project1Facade(AppContext appContext)
        {
            _appContext = appContext;

            _actorEntity = new EntityService<Actor>(_actorStore);
            _producerEntity = new EntityService<Producer>(_producerStore);
            _actorStore = new ActorStore(_appContext);
            _producerStore = new ProducerStore(_appContext);
            _genreStore = new GenreStore(_appContext);
            _movieStore = new MovieStore(_appContext);
            _showStore = new ShowStore(_appContext);
            _watchServieMovie = new WatchService<Movie>(_movieStore);
            _watchServieShow = new WatchService<Show>(_showStore);
        }

        public async Task Run()
        {
            await _producerStore.AddAsync(new Producer("Linkol", "Heisung"));
            await _actorStore.AddAsync(new Actor("Aron", "Piper"));
            await _genreStore.AddAsync(new Genre("Title1"));
            await _movieStore.AddAsync(new Movie("Movie1", "MovieDescription1", 1999, 10.0M, 1));
            await _showStore.AddAsync(new Show("Show1", "ShowDescription1", 1996, 9.0M, 1, 2));

            var first  = _watchServieMovie.GetGenre("Title1");

            foreach(var item in first)
            {
                Console.WriteLine($" _watchServieMovie.GetGenre(): {item.Id}, {item.Genres.Title}");
            }

            var second = _watchServieShow.GetYear(1996);

            foreach (var item in second)
            {
                Console.WriteLine($" _watchServieShow.GetYear(): {item.Id}, {item.Year}");
            }

            var third = _actorEntity.GetLastName("Piper");

            foreach (var item in third)
            {
                Console.WriteLine($"_actorEntity.GetLastName(): {item.LastName}");
            }
        }
    }
}
