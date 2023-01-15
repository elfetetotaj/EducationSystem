using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class ProgramEnrollment
    {
        [Key]
        public int ProgramEnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ProgramId { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Foreign Keys
        public Student Student { get; set; }
        public ProgramSchool ProgramSchool { get; set; }
    }

}
