using GloboTicket.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Server.Data
{
    public class ConferenceContext: DbContext
    {
        public ConferenceContext(DbContextOptions<ConferenceContext> options): base(options)
        {
        }

        public DbSet<Conference> Conferences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conference>().ToTable("Conference");
        }
    }
}
