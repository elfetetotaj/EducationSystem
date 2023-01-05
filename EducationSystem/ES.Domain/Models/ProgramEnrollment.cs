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
        public int ProgramEnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int ProgramID { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Student Student { get; set; }
        public ProgramSchool Program { get; set; }
    }

}
