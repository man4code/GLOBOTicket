using GloboTicket.Server.Models;
using GloboTicket.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Services
{
    public interface IConferenceService
    {
        public IEnumerable<Conference> GetConferences();
    }
}
