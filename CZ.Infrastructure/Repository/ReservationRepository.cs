using CZ.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infrastructure.Repository
{
    public class ReservationRepository : GenericRepository<Reservation>
    {
        public ReservationRepository() : base(new EFCZContext())
        {
        }

        public async Task<IList<Reservation>> GetClientReservationByClientId(int clientId)
        {
            return await this.DbContext.Reservations
                .Include(r => r.Client)
                .Where(r => r.Client.Id == clientId).ToListAsync();
        }

    }
}
