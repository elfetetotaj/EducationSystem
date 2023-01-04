using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CreditHours { get; set; }
        public string Description { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CoursePrerequisite> Prerequisites { get; set; }
        public ICollection<CoursePrerequisite> PrerequisiteFor { get; set; }
        public ICollection<InstructorCourseHistory> InstructorCourseHistories { get; set; }
        public ICollection<ProgramCourse> ProgramCourses { get; set; }
        public ICollection<CourseEnrollmentHistory> CourseEnrollmentHistories { get; set; }
        public ICollection<CourseSchedule> CourseSchedules { get; set; }
    }

}
