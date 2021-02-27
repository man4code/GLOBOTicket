using GloboTicket.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Server.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ConferenceContext conferenceContext)
        {
            conferenceContext.Database.EnsureCreated();

            if (conferenceContext.Conferences.Any())
            {
                return;
            }

            var conf = new Conference()
            {
                Name = "First Event",
                EventDate = DateTime.Now.AddDays(5),
                IsActive = true,
                OrganiserName = "Test Orrganizer",
                ParticipantCount = 60,
                Price = 2000,
                Venue = "Bangalore"
            };
            conferenceContext.Conferences.Add(conf);
            conferenceContext.SaveChanges();
        }
    }
}
