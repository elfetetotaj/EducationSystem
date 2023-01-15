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
        public int CourseEnrollmentHistoryId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Foreign Keys
        public Student Student { get; set; }
        public Course Course { get; set; }
    }

}
