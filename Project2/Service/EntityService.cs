using Project1.Model;
using Project1.Interface.Service;
using Project1.Interface.Model;
namespace Project1.Service
{
    public class EntityService<T> where T : IActorProducer
    {
        private readonly IActorProducerStore<T> _actorProducerStore;

        public EntityService(IActorProducerStore<T> actorProducerStore)
        {
            _actorProducerStore = actorProducerStore;
        }

        public IList<T> GetLastName(string lastName)
        {
            return _actorProducerStore.GetEntityLastName().Where(a => a.LastName==lastName).ToList();
        }
    }
}
