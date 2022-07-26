using Project1.Interface.Service;
using Project1.Interface.Model;
using Project1.Model;
namespace Project1.Service
{
    public class WatchService<T> where T : IMovieShow
    {
        private readonly IMovieShowStore<T> _store;

        public WatchService(IMovieShowStore<T> store)
        {
            _store = store;
        }

        public IList<T> GetGenre(string title)
        {
            return _store.GetEntityGenre().Where(a => a.Genres.Title == title).ToList();
        }

        public IList<T> GetYear(int year)
        {
            return _store.GetEntityYear().Where(a => a.Year == year).ToList();
        }
    }
}
