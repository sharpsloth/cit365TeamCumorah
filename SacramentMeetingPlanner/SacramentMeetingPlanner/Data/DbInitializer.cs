using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SacramentMeetingPlannerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any planners
            if (context.SacramentMeeting.Any())
            {
                return; // DB has already been seeded
            }

            var planners = new SacramentMeeting[]
            {
                new SacramentMeeting
                {
                    MeetingDate=DateTime.Parse("2020-05-24"),
                    ConductingLeader="Byron Lee",
                    OpeningSong="Now Let Us Rejoice",
                    SacramentHymn="There is a Green Hill Far Away",
                    ClosingSong="God Be With You",
                    IntermediateNumber="A Child's Prayer",
                    OpeningPrayer="Tommy Mendenhall",
                    ClosingPrayer="Sara Sites"
                },
                new SacramentMeeting
                {
                    MeetingDate=DateTime.Parse("2020-05-31"),
                    ConductingLeader="Sam North",
                    OpeningSong="Lead, Kindly Light",
                    SacramentHymn="Testimony",
                    ClosingSong="Sing We Now at Parting",
                    IntermediateNumber="I am a Child of God",
                    OpeningPrayer="Rebecca Wright",
                    ClosingPrayer="Lauren Call"
                },
                new SacramentMeeting
                {
                    MeetingDate=DateTime.Parse("2020-06-07"),
                    ConductingLeader="Tony Mendenhall",
                    OpeningSong="Come, Come Ye Saints",
                    SacramentHymn="More Holiness Give Me",
                    ClosingSong="Oh, Say What is True",
                    IntermediateNumber="Gethsemane",
                    OpeningPrayer="Regina Hinckley",
                    ClosingPrayer="Roger Wiblin"
                },
                new SacramentMeeting

                {
                    MeetingDate=DateTime.Parse("2020-06-14"),
                    ConductingLeader="Byron Lee",
                    OpeningSong="The Voice of God Again is Heard",
                    SacramentHymn="The Morning Breaks",
                    ClosingSong="Truth Eternal",
                    IntermediateNumber="High on the Mountain Top",
                    OpeningPrayer="Dorj Badam",
                    ClosingPrayer="Jordyn Gebs"
                },
                new SacramentMeeting
                {
                    MeetingDate=DateTime.Parse("2020-06-21"),
                    ConductingLeader="Sam North",
                    OpeningSong="Redeemer of Israel",
                    SacramentHymn="Israel, Israel, God is Calling",
                    ClosingSong="Awake and Arise",
                    IntermediateNumber="Come, Rejoice",
                    OpeningPrayer="Michael Owen",
                    ClosingPrayer="Sarah Tyre"
                },
                new SacramentMeeting
                {
                    MeetingDate=DateTime.Parse("2020-06-28"),
                    ConductingLeader="Tony Mendenhall",
                    OpeningSong="Come, Sing to the Lord",
                    SacramentHymn="What Was Witnessed in the Heavens",
                    ClosingSong="'Twas Witnessed in the Morning Sky",
                    IntermediateNumber="An Angel from on High",
                    OpeningPrayer="Greg Snowden",
                    ClosingPrayer="Abby Lopresti"
                },
                new SacramentMeeting
                {
                    MeetingDate=DateTime.Parse("2020-07-05"),
                    ConductingLeader="Byron Lee",
                    OpeningSong="Sweet Is the Peace the Gospel Brings",
                    SacramentHymn="I Saw a Mighty Angel Fly",
                    ClosingSong="What Glorious Scenes mine Eyes Behold",
                    IntermediateNumber="Awake, Ye Saints of God, Awake!",
                    OpeningPrayer="Megan Embody",
                    ClosingPrayer="Bart Brown"
                } };
            context.SacramentMeeting.AddRange(planners);
            context.SaveChanges();

            var talks = new Speakers[]
            {
                new Speakers{SacramentMeetingId=1,Name="Tony Mendenhall",Subject="Faith"},
                new Speakers{SacramentMeetingId=1,Name="Bart Brown",Subject="Faith"},
                new Speakers{SacramentMeetingId=1,Name="Phil Holt",Subject="Faith"},
                new Speakers{SacramentMeetingId=2,Name="Tammy Baker",Subject="Hope"},
                new Speakers{SacramentMeetingId=2,Name="Elizabeth Peterson",Subject="Hope"},
                new Speakers{SacramentMeetingId=3,Name="William Hansen",Subject="Charity"},
                new Speakers{SacramentMeetingId=3,Name="Macie Greene",Subject="Charity"},
                new Speakers{SacramentMeetingId=3,Name="Jerry Zazzie",Subject="Charity"},
                new Speakers{SacramentMeetingId=5,Name="Eleanor Barlow",Subject="Enduring Trials"},
                new Speakers{SacramentMeetingId=5,Name="Erica Wilde",Subject="Enduring Trials"},
                new Speakers{SacramentMeetingId=5,Name="Bruna Laurenco",Subject="Enduring Trials"},
                new Speakers{SacramentMeetingId=6,Name="Ralph Knox",Subject="Service"},
                new Speakers{SacramentMeetingId=6,Name="Claire Phillips",Subject="Service"},
                new Speakers{SacramentMeetingId=7,Name="Heather Smallwood",Subject="Forgiveness"},
                new Speakers{SacramentMeetingId=7,Name="Frank Butler",Subject="Forgiveness"},
                new Speakers{SacramentMeetingId=7,Name="Nancy Brown",Subject="Forgiveness"}
            };

            context.Speakers.AddRange(talks);
            context.SaveChanges();
        }
    }
}
