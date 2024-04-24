using CZ.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infrastructure.Repository
{
    public class TableRepository : GenericRepository<Table>
    {
        public TableRepository() : base(new EFCZContext()) { }

        public async Task<Table> GetById(int id)
        {
            return await this.DbContext.Tables.Where(t => t.Id == id).FirstAsync();
        }
    }
}
