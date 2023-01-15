using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class ProgramSchool
    {
        [Key]
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string Description { get; set; }

        //Foreign Keys
        public ICollection<ProgramEnrollment> ProgramEnrollments { get; set; }
        public ICollection<ProgramCourse> ProgramCourses { get; set; }
    }

}
