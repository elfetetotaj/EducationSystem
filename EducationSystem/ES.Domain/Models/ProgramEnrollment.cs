using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class ProgramEnrollment
    {
        public int ProgramEnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int ProgramID { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Student Student { get; set; }
        public Program Program { get; set; }
    }

}
