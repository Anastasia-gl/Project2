using Project1.Interface.Service;
using Project1.Model;
namespace Project1.Service
{
    public class ProducerStore : IActorProducerStore<Producer>
    {
        private readonly AppContext _dbContext;

        public ProducerStore(AppContext appContext)
        {
            _dbContext = appContext;
        }

        public async Task AddAsync(Producer producer)
        {
            _dbContext.Add(producer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(Producer producer)
        {
            _dbContext.Remove(producer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Producer producer)
        {
            if (producer != null)
            {
                _dbContext.Producer.Update(producer);
            }

            await _dbContext.SaveChangesAsync();
        }

        public IList<Producer> GetEntityLastName()
        {
            return _dbContext.Producer.ToList();
        }
    }
}
