using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ES.Domain.Models
{
    public class StudentGrade
    {
        [Key]
        public int StudentGradeId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string AssignmentName { get; set; }
        public int Grade { get; set; }

        //Foreign Keys
        public Student Student { get; set; }
        public Course Course { get; set; }
    }

}
