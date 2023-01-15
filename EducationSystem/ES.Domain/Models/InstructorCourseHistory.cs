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
        public int InstructorCourseHistoryId { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string SemesterTaught { get; set; }

        //Foreign Keys
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
