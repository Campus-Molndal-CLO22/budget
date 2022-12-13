using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget.entity
{
    public class Utgifter
    {
        [Key]
        public int Hyra { get; set; }
        public int Netflix { get; set; }
        public int Bredband { get; set; }
        public int Busskort { get; set; }
        public int Mat { get; set; }
        public int Försäkring { get; set; }
        public int Gym { get; set; }
    }
}
