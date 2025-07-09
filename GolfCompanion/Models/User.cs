using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfCompanion.Models
{ 
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public double Handicap { get; set; }

        public string Gender { get; set; }

        public List<Club> Clubs { get; set; }
        public ICollection<Round> Rounds { get; set; }
    }
}
