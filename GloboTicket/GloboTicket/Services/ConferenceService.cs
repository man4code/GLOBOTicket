using GloboTicket.Server.Data;
using GloboTicket.Server.Models;
using GloboTicket.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Services
{
    public class ConferenceService: IConferenceService
    {
        private readonly BookingsContext _conferenceContext;
        public ConferenceService(BookingsContext conferenceContext)
        {
            _conferenceContext = conferenceContext;
        }
        public IEnumerable<Conference> GetConferences()
        {
            var conferenceList = new List<Conference>();
            var result = _conferenceContext.Bookings.ToList();
            foreach (var item in result)
            {
                var conference = new Conference();
                conference.Name = item.Name;
                conference.OrganiserName = item.OrganiserName;
                conference.EventDate = item.EventDate;
                conference.Venue = item.Venue;
                conferenceList.Add(conference);
            }
            return conferenceList;
        }
    }
}
