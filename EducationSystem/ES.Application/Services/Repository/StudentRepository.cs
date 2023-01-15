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
    public class StudentRepository : GenericRepository<Student>, IStudent
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }

}
