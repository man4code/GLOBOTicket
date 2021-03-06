using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloboTicket.Server.Models;
using GloboTicket.Services;
using GloboTicket.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.Controllers
{
    [Route("api/[controller]")]
    public class ConferenceController: ControllerBase
    {
        private readonly IConferenceService _conferenceService;
        public ConferenceController(IConferenceService conferenceService)
        {
            _conferenceService = conferenceService;
        }

        [HttpGet]
        public IEnumerable<Conference> Get()
        {
            var result = _conferenceService.GetConferences();
            return result;
        }
    }
}
