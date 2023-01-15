using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class StudentAttendance
    {
        [Key]
        public int StudentAttendanceId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public bool IsPresent { get; set; }

        //Foreign Keys
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
