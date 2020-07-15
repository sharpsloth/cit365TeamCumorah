using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeeting
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [Display(Name ="Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [Required]
        [Display(Name = "Conducting Leader")]
        public string ConductingLeader { get; set; }

        [Display(Name = "Opening Song")]
        [Range(1, 341)]
        public string OpeningSong { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [Range(1, 341)]
        public string SacramentHymn { get; set; }

        [Display(Name = "Closing Song")]
        [Range(1, 341)]
        public string ClosingSong { get; set; }

        [Display(Name = "Intermediate Song")]
        [Range(1, 341)]
        public string IntermediateNumber { get; set; }

        [Display(Name = "Opening Prayer")]
        [Required]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        [Required]
        public string ClosingPrayer { get; set; }

        [Display(Name = "Speakers")]
        [Required]
        public List<Speakers> Speakers { get; set; }
    }
}
