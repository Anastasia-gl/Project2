using Project1.Model;
using Project1.Interface.Service;
namespace Project1.Service
{
    public class GenreStore : IGenreStore
    {
        private readonly AppContext _dbContext;

        public GenreStore(AppContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Genre genre)
        {
            _dbContext.Add(genre);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(Genre genre)
        {
            _dbContext.Remove(genre);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Genre genre)
        {
            if (genre != null)
            {
                _dbContext.Genre.Update(genre);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
