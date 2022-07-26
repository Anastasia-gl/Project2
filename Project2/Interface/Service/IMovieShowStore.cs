namespace Project1.Interface.Service
{
    public interface IMovieShowStore<T>
    {
        public async Task AddAsync(T entity) { }

        public async Task RemoveAsync(T entity) { }

        public async Task EditAsync(T entity) { }

        public IList<T> GetEntityGenre();

        public IList<T> GetEntityYear();
    }
}
