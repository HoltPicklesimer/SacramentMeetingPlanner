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

        [Required]
        [StringLength(100)]
        [Display(Name = "Speaker")]
        public string SpeakerName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Meeting ID")]
        public int MeetingId { get; set; }

        // Navigation Properties
        public Meeting Meeting { get; set; }
    }
}
