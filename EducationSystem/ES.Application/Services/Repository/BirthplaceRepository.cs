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
    internal class BirthplaceRepository : GenericRepository<Birthplace>, IBirthplace
    {
        public BirthplaceRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Birthplace> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
