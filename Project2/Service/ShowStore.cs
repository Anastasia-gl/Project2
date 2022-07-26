using Project1.Interface.Service;
using Project1.Model;
using Microsoft.EntityFrameworkCore;

namespace Project1.Service
{
    public class ShowStore : IMovieShowStore<Show>
    {
        private readonly AppContext _dbContext;

        public ShowStore(AppContext appContext)
        {
            _dbContext = appContext;
        }
        public async Task AddAsync(Show show)
        {
            _dbContext.Add(show);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(Show show)
        {
            _dbContext.Remove(show);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Show show)
        {
            if (show != null)
            {
                _dbContext.Show.Update(show);
            }

            await _dbContext.SaveChangesAsync();
        }

        public IList<Show> GetEntityGenre()
        {
            return _dbContext.Show.Include(m => m.Genres).ToList();
        }

        public IList<Show> GetEntityYear()
        {
            return _dbContext.Show.ToList();
        }
    }
}
