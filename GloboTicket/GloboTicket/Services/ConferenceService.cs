using GloboTicket.Server.Data;
using GloboTicket.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Services
{
    public class ConferenceService: IConferenceService
    {
        private readonly ConferenceContext _conferenceContext;
        public ConferenceService(ConferenceContext conferenceContext)
        {
            _conferenceContext = conferenceContext;
        }
        public IEnumerable<Conference> GetConferences()
        {
            var result = _conferenceContext.Conferences.ToList();
            return result;
        }
    }
}
