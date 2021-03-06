using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Server.Models
{
    public class Bookings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
