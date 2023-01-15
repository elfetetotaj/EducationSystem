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
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get;set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }


        //Foreign Keys
        public Department Department { get; set; }
        public ICollection<InstructorCourseHistory> InstructorCourseHistories { get; set; }
    }

}
