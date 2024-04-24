using CZ.Domain;
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
    }
}
