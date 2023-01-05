using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class ProgramCourse
    {
        [Key]
        public int ProgramCourseID { get; set; }
        public int ProgramID { get; set; }
        public int CourseID { get; set; }
        public bool IsRequired { get; set; }

        public ProgramSchool Program { get; set; }
        public Course Course { get; set; }
    }

}
