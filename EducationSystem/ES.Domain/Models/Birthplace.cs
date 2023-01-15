using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Models
{
    public class Birthplace
    {
        [Key]
        public int BirthplaceId { get; set; }
        public string BirthplaceName { get; set;}


        public ICollection<Student> Students { get; set; }
    }
}
