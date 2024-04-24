using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain
{
    public class Reservation : BaseEntity
    {
        [Required]
        public Table Table { get; set; }

        [Required]
        public Daytime Daytime { get; set; }

        [Required]
        public DateTime Date { get; set; }

        private Reservation() { }

        public Reservation(Table table, Daytime daytime, DateTime date)
        {
            this.Table = table;
            this.Daytime = daytime;
            this.Date = date;
        }
    }
}
