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
        public int StudentAdvisorId { get; set; }
        public int StudentId { get; set; }
        public int AdvisorId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }

        //Foreign Keys
        public Student Student { get; set; }
        public Instructor Advisor { get; set; }
    }

}
