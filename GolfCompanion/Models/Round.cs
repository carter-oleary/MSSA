using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedGolfClasses;

namespace GolfCompanion.Models
{
    public class Round
    {
        [Key]
        public int RoundId { get; set; }

        public List<Shot> Shots { get; set; } = new();

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }

        public Tee Tee { get; set; }
        public double SG_Tee { get; set; }
        public double SG_App { get; set; }
        public double SG_Short { get; set; }
        public double SG_Putt { get; set; }
        


    }
}
