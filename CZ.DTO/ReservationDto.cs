using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.DTO
{
    public class ReservationDto
    {
        public TableDto Table { get; set; }
        public DateTime Date { get; set; }
    }
}
