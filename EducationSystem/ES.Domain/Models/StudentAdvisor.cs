using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class StudentAdvisor
    {
        [Key]
        public int StudentAdvisorID { get; set; }
        public int StudentID { get; set; }
        public int AdvisorID { get; set; }
        public DateTime StartDate { get; set; }

        public Student Student { get; set; }
        public Instructor Advisor { get; set; }
    }

}
