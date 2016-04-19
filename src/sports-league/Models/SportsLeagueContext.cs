using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sports_league.Models
{
    public class SportsLeagueContext : DbContext
    {
        public virtual DbSet<Team> Teams { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SportsLeague;integrated security = True");
        }
    }
}
