using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
   public class Meeting
   {
      public int MeetingId { get; set; }

      public DateTime MeetingDate { get; set; }

      [Required]
      [StringLength(100)]
      [Display(Name = "Conducting Leader")]
      public string Conductor { get; set; }

      [Required]
      [StringLength(100)]
      [Display(Name = "Opening Prayer")]
      public string OpeningPrayer { get; set; }

      [Required]
      [StringLength(100)]
      [Display(Name = "Closing Prayer")]
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
      [Display(Name = "Intermediate Hymn")]
      public string IntermediateHymn { get; set; }

      // Navigation Properties
      public ICollection<Speaker> Speakers { get; set; }
   }
}
