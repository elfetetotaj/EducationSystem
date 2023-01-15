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
        public int ProgramCourseId { get; set; }
        public int ProgramId { get; set; }
        public int CourseId { get; set; }
        public bool IsRequired { get; set; }


        //Foreign Keys
        public ProgramSchool ProgramSchool { get; set; }
        public Course Course { get; set; }
    }

}
