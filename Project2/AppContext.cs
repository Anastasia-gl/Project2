using Microsoft.EntityFrameworkCore;
using Project1.Model;

namespace Project1
{
    public class AppContext : DbContext
    {
        public DbSet<Actor> Actor { get; set; } 

        public DbSet<Cast> Cast { get; set; }

        public DbSet<Genre> Genre { get; set; }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<Show> Show { get; set; }

        public DbSet<Producer> Producer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EP3R97J;Initial Catalog=Project2;Integrated Security=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Actor Entity

            modelBuilder.Entity<Actor>()      
                .ToTable("Actor")
                .HasKey(a => a.Id);

            modelBuilder.Entity<Actor>()
                .Property(p => p.FisrtName)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Actor>()
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(20);

            //ActorMovieShow Entity

            modelBuilder.Entity<Cast>()
                .ToTable("Cast")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Cast>()
                .HasOne(e => e.Movie)
                .WithMany(w => w.Сast)
                .HasForeignKey(f => f.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Cast>()
                .HasOne(e => e.Show)
                .WithMany(w => w.Сast)
                .HasForeignKey(f => f.ShowId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Cast>()
                .HasOne(e => e.Producer)
                .WithMany(w => w.Cast)
                .HasForeignKey(w => w.ProducerId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            //Producer Entity

            modelBuilder.Entity<Producer>()
                .ToTable("Producer")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Producer>()
                .Property(p => p.FisrtName)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Producer>()
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(20);

            //Genre Entity

            modelBuilder.Entity<Genre>()
                .ToTable("Genre")
                .HasKey(e => e.GenreId);

            modelBuilder.Entity<Genre>()
                .Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(20);

            //Movie Entity

            modelBuilder.Entity<Movie>()
                .ToTable("Movie")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Movie>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Movie>()
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(100);

            //Show Entity

            modelBuilder.Entity<Show>()
               .ToTable("Show")
               .HasKey(e => e.Id);

            modelBuilder.Entity<Show>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Show>()
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
