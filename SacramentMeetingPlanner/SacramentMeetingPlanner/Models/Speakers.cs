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
        public string Name { get; set; }
        public string Subject { get; set; }
    }
}
