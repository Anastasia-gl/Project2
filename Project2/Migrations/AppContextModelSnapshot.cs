﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1;

#nullable disable

namespace Project1.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project1.Model.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FisrtName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Actor", (string)null);
                });

            modelBuilder.Entity("Project1.Model.Cast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.HasIndex("ProducerId");

                    b.HasIndex("ShowId");

                    b.ToTable("Cast", (string)null);
                });

            modelBuilder.Entity("Project1.Model.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre", (string)null);
                });

            modelBuilder.Entity("Project1.Model.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movie", (string)null);
                });

            modelBuilder.Entity("Project1.Model.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FisrtName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Producer", (string)null);
                });

            modelBuilder.Entity("Project1.Model.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("NumberSeasons")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Show", (string)null);
                });

            modelBuilder.Entity("Project1.Model.Cast", b =>
                {
                    b.HasOne("Project1.Model.Actor", "Actor")
                        .WithMany("Cast")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project1.Model.Movie", "Movie")
                        .WithMany("Сast")
                        .HasForeignKey("MovieId")
                        .IsRequired();

                    b.HasOne("Project1.Model.Producer", "Producer")
                        .WithMany("Cast")
                        .HasForeignKey("ProducerId")
                        .IsRequired();

                    b.HasOne("Project1.Model.Show", "Show")
                        .WithMany("Сast")
                        .HasForeignKey("ShowId")
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");

                    b.Navigation("Producer");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Project1.Model.Movie", b =>
                {
                    b.HasOne("Project1.Model.Genre", "Genres")
                        .WithMany("Movie")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");
                });

            modelBuilder.Entity("Project1.Model.Show", b =>
                {
                    b.HasOne("Project1.Model.Genre", "Genres")
                        .WithMany("Show")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");
                });

            modelBuilder.Entity("Project1.Model.Actor", b =>
                {
                    b.Navigation("Cast");
                });

            modelBuilder.Entity("Project1.Model.Genre", b =>
                {
                    b.Navigation("Movie");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Project1.Model.Movie", b =>
                {
                    b.Navigation("Сast");
                });

            modelBuilder.Entity("Project1.Model.Producer", b =>
                {
                    b.Navigation("Cast");
                });

            modelBuilder.Entity("Project1.Model.Show", b =>
                {
                    b.Navigation("Сast");
                });
#pragma warning restore 612, 618
        }
    }
}
