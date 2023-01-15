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
        public int BirthplaceId { get; set; }
        public string FirstName { get; set; }
        public string ParentName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool IsFullTime { get; set; }


        //Foreign Keys
        public Birthplace Birthplace { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<ProgramEnrollment> ProgramEnrollments { get; set; }
        public ICollection<CourseEnrollmentHistory> CourseEnrollmentHistories { get; set; }
        public ICollection<StudentGrade> StudentGrades { get; set; }
        public ICollection<StudentAttendance> StudentAttendances { get; set; }
    }

}
