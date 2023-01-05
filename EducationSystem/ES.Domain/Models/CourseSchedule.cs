using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class CourseSchedule
    {
        [Key]
        public int CourseScheduleID { get; set; }
        public int CourseID { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public Course Course { get; set; }
    }

}
