using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public int? Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }

}
