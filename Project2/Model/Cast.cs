namespace Project1.Model
{
    public class Cast
    {
        public Cast(int id, int actorId, int movieId, int showId)
        {
            Id = id;
            ActorId = actorId;
            MovieId = movieId;
            ShowId = showId;
        }

        public int Id { get; set; }

        public int ActorId { get; set; }

        public int MovieId { get; set; }

        public int ProducerId { get; set; }

        public int ShowId { get; set; }

        public Actor Actor { get; set; }

        public Show Show { get; set; }

        public Producer Producer { get; set; }

        public Movie Movie { get; set; }

    }
}
