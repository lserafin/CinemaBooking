using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CinemaBooking.Data;

namespace CinemaBooking.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("CinemaBooking.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CinemaBooking.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MovieId");

                    b.Property<string>("RoomName");

                    b.HasKey("RoomId");

                    b.HasIndex("MovieId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CinemaBooking.Models.Screening", b =>
                {
                    b.Property<int>("ScreeningId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MovieId");

                    b.Property<int?>("RoomId");

                    b.Property<DateTime>("Time");

                    b.HasKey("ScreeningId");

                    b.HasIndex("MovieId");

                    b.HasIndex("RoomId");

                    b.ToTable("Screenings");
                });

            modelBuilder.Entity("CinemaBooking.Models.Room", b =>
                {
                    b.HasOne("CinemaBooking.Models.Movie")
                        .WithMany("PlayingAt")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("CinemaBooking.Models.Screening", b =>
                {
                    b.HasOne("CinemaBooking.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId");

                    b.HasOne("CinemaBooking.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");
                });
        }
    }
}
