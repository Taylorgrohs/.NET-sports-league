using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using sports_league.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sports_league.Controllers
{
    public class TeamsController : Controller
    {
        private SportsLeagueContext db = new SportsLeagueContext();
        public IActionResult Index()
        {
            return View(db.Teams.Include(x => x.Division).ToList());
        }

        public IActionResult Details(int id)
        {
            var thisTeam = db.Teams.FirstOrDefault(x => x.TeamId == id);
            return View(thisTeam);
        }
        
        public IActionResult Create()
        {
            ViewBag.DivisionId = new SelectList(db.Division, "DivisionId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Team team)
        {
            db.Teams.Add(team);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var thisTeam = db.Teams.FirstOrDefault(d => d.TeamId == id);
            ViewBag.DivisionId = new SelectList(db.Division, "DivisionId", "Name");
            return View(thisTeam);
        }

        [HttpPost]
        public ActionResult Edit(Team team)
        {
            db.Entry(team).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var thisTeam = db.Teams.FirstOrDefault(d => d.TeamId == id);
            return View(thisTeam);
        }
        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisTeam = db.Teams.FirstOrDefault(d => d.TeamId == id);
            db.Teams.Remove(thisTeam);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
