using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool IsFullTime { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<ProgramEnrollment> ProgramEnrollments { get; set; }
        public ICollection<CourseEnrollmentHistory> CourseEnrollmentHistories { get; set; }
        public ICollection<StudentGrade> StudentGrades { get; set; }
        public ICollection<StudentAttendance> StudentAttendances { get; set; }
    }

}
