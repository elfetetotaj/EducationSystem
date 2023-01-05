using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }

        public Department Department { get; set; }
        public ICollection<InstructorCourseHistory> InstructorCourseHistories { get; set; }
    }

}
