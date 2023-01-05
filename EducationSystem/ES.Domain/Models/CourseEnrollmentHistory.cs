using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class CourseEnrollmentHistory
    {
        [Key]
        public int CourseEnrollmentHistoryID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }

}
