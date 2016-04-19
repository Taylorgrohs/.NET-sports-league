using Microsoft.AspNet.Mvc;
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
            return View(db.Teams.ToList());
        }
    }
}
