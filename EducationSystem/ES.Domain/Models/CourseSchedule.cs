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
        public int CourseScheduleId { get; set; }
        public int CourseId { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        //Foreign Keys
        public Course Course { get; set; }
    }

}
