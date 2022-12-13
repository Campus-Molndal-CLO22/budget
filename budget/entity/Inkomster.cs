using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget.entity
{
    public class Inkomster
    {
        [Key]
        public int Lön { get; set; }
        public int Bidrag { get; set; }
    }
}
