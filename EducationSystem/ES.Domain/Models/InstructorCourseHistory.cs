using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class InstructorCourseHistory
    {
        [Key]
        public int InstructorCourseHistoryID { get; set; }
        public int InstructorID { get; set; }
        public int CourseID { get; set; }
        public string SemesterTaught { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
