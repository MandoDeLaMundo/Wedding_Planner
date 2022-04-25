using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Wedding_Planner.Models;

namespace Wedding_Planner.Controllers
{
    public class WeddingsController : Controller
    {
        private WeddingPlannerContext db;
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        public WeddingsController(WeddingPlannerContext context)
        {
            db = context;
        }

        [HttpGet("/weddings")]
        public IActionResult All()
        {
            if (uid == null)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Wedding> allWeddings = db.Weddings
                .Include(w => w.Planner)
                .Include(w => w.WeddingGuestRSVPd)
                .ToList();
            
            return View("All", allWeddings);
        }

        [HttpGet("/weddings/new")]
        public IActionResult New()
        {
            if (uid == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View("New");
        }

        [HttpPost("/weddings/create")]
        public IActionResult Create(Wedding wedding)
        {
            if (uid == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid == false)
            {
                return View("New");
            }

            wedding.UserId = (int)uid;
            db.Weddings.Add(wedding);
            db.SaveChanges();
            return RedirectToAction("All");
        }

        [HttpPost("/weddings/{weddingId}/rsvp")]
        public IActionResult RSVP(int weddingId)
        {
            if (uid == null)
            {
                return RedirectToAction("Index", "Home");
            }

            WeddingGuestRSVP existingRSVP = db.WeddingGuestRSVPs.FirstOrDefault(w => w.WeddingId == weddingId && w.UserId == uid);

            if (existingRSVP == null)
            {
                WeddingGuestRSVP newRSVP = new WeddingGuestRSVP()
                {
                    UserId = (int)uid,
                    WeddingId = weddingId
                };

                db.WeddingGuestRSVPs.Add(newRSVP);
            }
            else
            {
                db.Remove(existingRSVP);
            }

            db.SaveChanges();
            return RedirectToAction("Details",new {weddingId = weddingId});
        }

        [HttpGet("/weddings/{weddingId}")]
        public IActionResult Details(int weddingId)
        {
            if (uid == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding wedding = db.Weddings
                .Include(w => w.Planner)
                .Include(w => w.WeddingGuestRSVPd).ThenInclude(RSVP => RSVP.User)
                .FirstOrDefault(w => w.WeddingId == weddingId);

            if (wedding == null)
            {
                return RedirectToAction("All");
            }
            return View("Details", wedding);
        }

        [HttpPost("/weddings/{weddingId}/delete")]
        public IActionResult Delete(int weddingId)
        {
            if (uid == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding wedding = db.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);

            if (wedding == null || wedding.UserId != uid)
            {
                return RedirectToAction("All");
            }

            db.Weddings.Remove(wedding);
            db.SaveChanges();
            return RedirectToAction("All");
        }
    }
}
