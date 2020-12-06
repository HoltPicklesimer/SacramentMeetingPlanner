using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
   public class Speaker
   {
      public int SpeakerId { get; set; }

      [StringLength(100)]
      [Display(Name = "Speaker")]
      public string SpeakerName { get; set; }

      [StringLength(100)]
      [Display(Name = "Subject")]
      public string Subject { get; set; }

      public int MeetingId { get; set; }

      // Navigation Properties
      public Meeting Meeting { get; set; }
   }
}
