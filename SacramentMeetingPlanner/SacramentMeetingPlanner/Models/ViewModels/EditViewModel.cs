using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models.ViewModels
{
    public class EditViewModel
    {
        public int Id { get; set; }
        public DateTime MeetingDate { get; set; }

        public string ConductingLeader { get; set; }

        public string OpeningSong { get; set; }

        public string SacramentHymn { get; set; }

        public string ClosingSong { get; set; }

        public string IntermediateNumber { get; set; }

        public string OpeningPrayer { get; set; }

        public string ClosingPrayer { get; set; }

    
        public List<Speakers> Speakers { get; set; }
    }
}
