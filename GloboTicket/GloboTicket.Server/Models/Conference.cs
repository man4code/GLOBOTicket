using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Server.Models
{
    public class Conference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public string OrganiserName { get; set; }
        public int ParticipantCount { get; set; }
        public string Venue { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
