using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class StudentGrade
    {
        public int StudentGradeID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public string AssignmentName { get; set; }
        public int Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }

}
