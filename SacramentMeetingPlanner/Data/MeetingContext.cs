using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Data
{
   public class MeetingContext : DbContext
   {
      public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
      {
      }

      public DbSet<Meeting> Meetings { get; set; }
      public DbSet<Speaker> Speakers { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Meeting>().ToTable("Meeting");
         modelBuilder.Entity<Speaker>().ToTable("Speaker");
      }
   }
}
