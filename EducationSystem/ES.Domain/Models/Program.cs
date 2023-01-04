using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class Program
    {
        public int ProgramID { get; set; }
        public string ProgramName { get; set; }
        public string Description { get; set; }

        public ICollection<ProgramEnrollment> ProgramEnrollments { get; set; }
        public ICollection<ProgramCourse> ProgramCourses { get; set; }
    }

}
