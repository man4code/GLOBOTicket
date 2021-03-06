using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.ViewModels
{
    public class Conference
    {
        public string Name { get; set; }
        public string OrganiserName { get; set; }
        public DateTime EventDate { get; set; }
        public string Venue { get; set; }
    }
}
