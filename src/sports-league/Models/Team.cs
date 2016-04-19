using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sports_league.Models
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public string PlayerThree { get; set; }
        public string Captain { get; set; }
        public int DivisionId { get; set; }
        public virtual Division Division { get; set; }
    }
}
