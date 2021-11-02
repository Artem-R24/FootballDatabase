using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab
{
    public class Coach
    {
        [Key]
        [ForeignKey("Team")]
        public int CoachId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Team Team { get; set; }
    }
}
