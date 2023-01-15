using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class CoursePrerequisite
    {
        [Key]
        public int CoursePrerequisiteId { get; set; }
        public int CourseId { get; set; }
        public int MinimumGrade { get; set; }
        public int MinimumAbsence { get; set; }

        //Foreign Keys
        public Course Course { get; set; }
    }

}
