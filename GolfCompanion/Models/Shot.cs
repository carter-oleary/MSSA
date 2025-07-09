using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfCompanion.Models
{
    public enum ShotType { Tee, Recovery, Layup, Approach, Short, Putt }
    public enum Lie { Tee, Fairway, Rough, Sand, Green }
    public enum Result { OnTarget, Right, Left, Long, Short, Penalty }
    public class Shot
    {
        [Key]
        public int ShotId { get; set; }

        [ForeignKey("RoundId")]
        public int RoundId { get; set; }

        public Round Round { get; set; }

        [ForeignKey("HoleNumber")]
        public int HoleNumber { get; set; }

        public Club Club { get; set; }
        public ShotType ShotType { get; set; }
        public int Distance { get; set; }
        public string Lie {  get; set; }
        public Result Result { get; set; }
        public double StrokesGained { get; set; }

    }
}
