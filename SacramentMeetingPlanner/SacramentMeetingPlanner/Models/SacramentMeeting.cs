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
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public string ConductingLeader { get; set; }

        [Display(Name = "Opening Song")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public string OpeningSong { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public string SacramentHymn { get; set; }

        [Display(Name = "Closing Song")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public string ClosingSong { get; set; }

        [Display(Name = "Intermediate Song")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public string IntermediateNumber { get; set; }

        [Display(Name = "Opening Prayer")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public string ClosingPrayer { get; set; }

        [Display(Name = "Speakers")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public List<Speakers> Speakers { get; set; }
    }
}
