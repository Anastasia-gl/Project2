using Project1.Interface.Model;
namespace Project1.Model
{
    public class Actor : IActorProducer
    {
        public Actor(string fisrtName, string lastName)
        {
            FisrtName = fisrtName;
            LastName = lastName;
        }

        public int Id { get; set; }

        public string FisrtName { get; set; }

        public string LastName { get; set; }

        public IList<Cast> Cast { get; set; }
    }
}
