using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class CoursePrerequisite
    {
        public int CoursePrerequisiteID { get; set; }
        public int CourseID { get; set; }
        public int PrerequisiteCourseID { get; set; }
        public int MinimumGrade { get; set; }

        public Course Course { get; set; }
        public Course PrerequisiteCourse { get; set; }
    }

}
