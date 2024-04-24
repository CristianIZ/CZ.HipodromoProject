using CZ.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infrastructure.Repository
{
    public class DaytimeRepository : GenericRepository<Daytime>
    {
        public DaytimeRepository() : base(new EFCZContext())
        {

        }

        public async Task<Daytime> GetById(int id)
        {
            return await this.DbContext.Daytimes.Where(d => d.Id == id).FirstAsync();
        }
    }
}
