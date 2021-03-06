﻿using GloboTicket.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Server.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BookingsContext bookingContext)
        {
            bookingContext.Database.EnsureDeleted();
            bookingContext.Database.Migrate();
            //bookingContext.Database.EnsureCreated();

            if (bookingContext.Bookings.Any())
            {
                return;
            } 

            for (var i = 0; i < 10; i++)
            {
                var conf = new Bookings()
                {
                    Name = "First Event " + i,
                    EventDate = DateTime.Now.AddDays(5),
                    IsActive = true,
                    OrganiserName = "Test Orrganizer " + i,
                    ParticipantCount = 60,
                    Price = 2000,
                    Venue = "Bangalore 56007" + i
                };
                bookingContext.Bookings.Add(conf);
            }
            bookingContext.SaveChanges();
        }
    }
}
