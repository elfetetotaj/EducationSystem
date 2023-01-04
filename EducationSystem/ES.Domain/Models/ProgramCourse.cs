using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class ProgramCourse
    {
        public int ProgramCourseID { get; set; }
        public int ProgramID { get; set; }
        public int CourseID { get; set; }
        public bool IsRequired { get; set; }

        public Program Program { get; set; }
        public Course Course { get; set; }
    }

}
