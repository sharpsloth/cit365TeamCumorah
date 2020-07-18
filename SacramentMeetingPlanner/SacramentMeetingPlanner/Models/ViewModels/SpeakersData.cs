using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models.ViewModels
{
    public class SpeakersData
    {
        public int SpeakersID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int SacramentMeetingId { get; set; }
    }
}
