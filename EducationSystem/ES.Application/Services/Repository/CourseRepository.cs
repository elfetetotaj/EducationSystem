using ES.Application.Services.Interfaces;
using ES.Domain.Models;
using ES.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Application.Services.Repository
{
    public class CourseRepository : GenericRepository<Course>, ICourse
    {
        public CourseRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
