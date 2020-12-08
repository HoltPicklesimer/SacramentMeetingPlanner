using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        [Display(Name = "Meeting ID")]
        public int MeetingId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Conducting")]
        public string Conductor { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Invocation")]
        public string OpeningPrayer { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Benediction")]
        public string ClosingPrayer { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [StringLength(100)]
        [Display(Name = "Intermediate Hymn (optional)")]
        public string IntermediateHymn { get; set; }

        // Navigation Properties
        public ICollection<Speaker> Speakers { get; set; }
    }
}
