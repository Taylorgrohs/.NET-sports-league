using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sports_league.Models
{
    [Table("Division")]
    public class Division
    {
        public Division()
        { 
            this.Teams = new HashSet<Team>();
        }

        [Key]
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public int Skill { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
