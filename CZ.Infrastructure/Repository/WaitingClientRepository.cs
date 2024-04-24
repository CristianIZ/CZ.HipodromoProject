using CZ.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infrastructure.Repository
{
    public class WaitingClientRepository : GenericRepository<WaitingClient>
    {
        public WaitingClientRepository() : base(new EFCZContext())
        {

        }

        public async Task<WaitingClient?> GetByClientKey(Guid clientKey)
        {
            return await this.DbContext.WaitingLists.Where(w => w.Client.Key == clientKey).FirstOrDefaultAsync();
        }

        public async Task RemoveClientFromList(Guid clientKey)
        {
            var waitingClient = this.DbContext.WaitingLists.Where(w => w.Client.Key == clientKey).First();
            this.DbContext.WaitingLists.Remove(waitingClient);
            await this.DbContext.SaveChangesAsync();
        }
    }
}
