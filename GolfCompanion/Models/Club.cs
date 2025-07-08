using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfCompanion.Models
{
    public class Club
    {
        [Key] 
        public int ClubId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string ClubName { get; set; }
        public int? ClubDistance { get; set; }
    }
}
