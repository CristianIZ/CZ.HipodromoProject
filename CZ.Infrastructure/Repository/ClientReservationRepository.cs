using CZ.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infrastructure.Repository
{
    public class ClientReservationRepository : GenericRepository<ClientReservation>
    {
        public ClientReservationRepository() : base(new EFCZContext()) { }

        public async Task<IList<ClientReservation>> GetClientReservationByClientKey(Client client)
        {
            return await this.DbContext.ClientReservations.Where(c => c.Client.Key == client.Key).ToListAsync();
        }
    }
}
