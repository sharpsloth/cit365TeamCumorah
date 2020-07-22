using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SacramentMeetingPlanner.Models
{
    public class Speakers
    {
        public int Id { get; set; }
        public int SacramentMeetingId { get; set; }
        [Required]
        [Display(Name = "Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Subject")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public string Subject { get; set; }
    }
}
