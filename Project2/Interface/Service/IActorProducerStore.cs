namespace Project1.Interface.Service
{
    public interface IActorProducerStore<T>
    {
        public async Task AddAsync(T entity) { }

        public async Task RemoveAsync(T entity) { }

        public async Task EditAsync(T entity) { }

        public IList<T> GetEntityLastName();
    }
}
