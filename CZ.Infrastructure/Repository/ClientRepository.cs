using CZ.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infrastructure.Repository
{
    public class ClientRepository : GenericRepository<Client>
    {
        public ClientRepository() : base(new EFCZContext())
        {
        }

        public async Task<Client?> GetClient(Guid key)
        {
            return await this.DbContext.Clients
                                       .Include(c => c.Category)
                                       .Where(c => c.Key == key).FirstOrDefaultAsync();
        }

        public async Task<IList<Client>> GetByClient(Guid key)
        {
            return await this.DbContext.Clients.Where(c => c.Key == key).ToListAsync();
        }
    }
}
