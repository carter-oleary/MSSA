using SharedGolfClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfCompanion.Models
{
    public class IndexedHole
    {
        public int Index { get; set; }
        public Hole Hole { get; set; }

        public string DisplayText => $"Hole {Index + 1}";
    }
}
