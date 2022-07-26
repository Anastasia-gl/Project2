using Project1.Model;
namespace Project1.Interface.Model
{
    public interface IActorProducer
    {
        public int Id { get; set; }

        public string FisrtName { get; set; }

        public string LastName { get; set; }

        public IList<Cast> Cast { get; set; }
    }
}
