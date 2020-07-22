using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;
using SacramentMeetingPlanner.Models.ViewModels;

namespace SacramentMeetingPlanner.Controllers
{
    public class SacramentMeetingsController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public SacramentMeetingsController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: SacramentMeetings
        public async Task<IActionResult> Index()
        {
            var sacrament = _context.SacramentMeeting
                .Include(s => s.Speakers)
                .AsNoTracking();
            return View(await sacrament.ToListAsync());
        }

        // GET: SacramentMeetings Talk History
        public async Task<IActionResult> TalkHistory()
        {
            var sacrament = _context.SacramentMeeting
                .Include(s => s.Speakers)
                .AsNoTracking();
            return View(await sacrament.ToListAsync());
        }


        // GET: SacramentMeetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeeting
                .Include(s => s.Speakers)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }

            return View(sacramentMeeting);
        }

        // GET: SacramentMeetings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SacramentMeetings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MeetingDate,ConductingLeader,OpeningSong,SacramentHymn,ClosingSong,IntermediateNumber,OpeningPrayer,ClosingPrayer, Speakers")] SacramentMeeting sacramentMeeting)
        {
            Console.WriteLine(JsonConvert.SerializeObject(sacramentMeeting));
            if (ModelState.IsValid)
            {
                _context.Add(sacramentMeeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sacramentMeeting);
        }

        // GET: SacramentMeetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeeting
                .Include(s => s.Speakers)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            
            if (sacramentMeeting == null)
            {
                return NotFound();
            }
            PopulateSpeakersData(sacramentMeeting);
            return View(sacramentMeeting);
        }

        private void PopulateSpeakersData(SacramentMeeting sacramentMeeting)
        {
            var allSpeakers = _context.Speakers.Where(i => i.SacramentMeetingId == sacramentMeeting.Id);
            var sacramentSpeakers = new HashSet<int>(sacramentMeeting.Speakers.Select(s => s.Id));
            var viewModel = new List<SpeakersData>();
            foreach (var speaker in allSpeakers)
            {
                viewModel.Add(new SpeakersData
                {
                    SpeakersID = speaker.Id,
                    Name = speaker.Name,
                    Subject = speaker.Subject,
                    SacramentMeetingId = speaker.SacramentMeetingId
                });
            }
            ViewData["Speakers"] = viewModel;
        }

        // POST: SacramentMeetings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Speakers[] speakers)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentToUpdate = await _context.SacramentMeeting
                .Include(i => i.Speakers)
                .FirstOrDefaultAsync(m => m.Id == id);

            

            if( await TryUpdateModelAsync<SacramentMeeting>(
                sacramentToUpdate,
                "",
                i => i.MeetingDate,
                i => i.ConductingLeader,
                i => i.OpeningSong,
                i => i.SacramentHymn,
                i => i.ClosingSong,
                i => i.IntermediateNumber,
                i => i.OpeningPrayer,
                i => i.ClosingPrayer))
            {
                UpdateSacramentSpeakers(speakers, sacramentToUpdate);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persistes, " +
                        "see your system administrator.");
                }
                return RedirectToAction(nameof(Index));
            }
            UpdateSacramentSpeakers(speakers, sacramentToUpdate);
            PopulateSpeakersData(sacramentToUpdate);
            return View(sacramentToUpdate);
        }

        private void UpdateSacramentSpeakers(Speakers[] speakers, SacramentMeeting sacramentToUpdate)
        {
            if (speakers == null)
            {
                sacramentToUpdate.Speakers = new List<Speakers>();
                return;
            }
            // set of Ids of all speakers currently connected to edited sacramantMeeting
            var sacramentSpeakers = new HashSet<int>
                (sacramentToUpdate.Speakers.Select(c => c.Id));
           
            //set of edited speakers
            var speakersHS = new HashSet<Speakers>(speakers);
            //create set of edited speaker IDs
            var speakerIDs = new HashSet<int>();
            // add each ID to the set
            foreach (var speaker in speakersHS) 
            {
                speakerIDs.Add(speaker.Id);
                // if it is not already connected to the edited sacramentMeeting
                if (!sacramentSpeakers.Contains(speaker.Id))
                {
                    // add the speaker
                    sacramentToUpdate.Speakers.Add(new Speakers { SacramentMeetingId = sacramentToUpdate.Id, Name = speaker.Name, Subject = speaker.Subject });
                }
            }

            // for each speaker in the database connected to the edited sacramentMeeting
            foreach (var speaker in _context.Speakers.Where(r => sacramentSpeakers.Contains(r.Id)))
            {
                // if it is found on the edited speaker list
                if (speakerIDs.Contains(speaker.Id))
                {
                    // update the speaker
                    sacramentToUpdate.Speakers.Add(speaker);
                }
                // if it is not found on the edited speaker list
                else
                {
                    // delete the speaker
                    Speakers speakersToRemove = sacramentToUpdate.Speakers.FirstOrDefault(i => i.Id == speaker.Id);
                    _context.Remove(speakersToRemove);
                }
            }
        }

        // GET: SacramentMeetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeeting
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }

            return View(sacramentMeeting);
        }

        // POST: SacramentMeetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sacramentMeeting = await _context.SacramentMeeting.FindAsync(id);
            _context.SacramentMeeting.Remove(sacramentMeeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SacramentMeetingExists(int id)
        {
            return _context.SacramentMeeting.Any(e => e.Id == id);
        }
    }
}
