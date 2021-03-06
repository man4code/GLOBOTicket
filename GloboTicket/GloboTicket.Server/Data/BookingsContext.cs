using GloboTicket.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Server.Data
{
    public class BookingsContext: DbContext
    {
        public BookingsContext(DbContextOptions<BookingsContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var i = 1;
            modelBuilder.Entity<Bookings>()
                .HasData(
                new  Bookings()
                {
                    Id = i,
                    Name = "First Event " + i,
                    EventDate = DateTime.Now.AddDays(5),
                    IsActive = true,
                    OrganiserName = "Test Orrganizer " + i,
                    ParticipantCount = 60,
                    Price = 2000,
                    Venue = "Bangalore 56007" + i,
                    UserId = i,
                    BookingType = BookingType.Conference
                });

            modelBuilder.Entity<User>()
                .HasData(
                new User()
                {
                    Id = i,
                    Name = "Test User" + i,
                    EmailId = "test@test.com"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
