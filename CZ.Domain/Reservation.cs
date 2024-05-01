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
        public Client Client { get; set; }
        public int ClientId { get; set; }

        [Required]
        public Table Table { get; set; }
        public int TableId { get; set; }

        [Required]
        public Daytime Daytime { get; set; }
        public int DaytimeId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        private Reservation() { }

        public Reservation(IList<Reservation> clientReservations, Client client, Table table, Daytime daytime, DateTime date)
        {
            switch (client.Category.Name)
            {
                case "Classic":
                    if (DateTime.Now.AddHours(48) < date)
                        throw new Exception("Cannot create a reservation for a Classic client with more than 48 hours of anticipation");
                    break;

                case "Gold":
                    if (DateTime.Now.AddHours(72) < date)
                        throw new Exception("Cannot create a reservation for a Gold client with more than 72 hours of anticipation");
                    break;

                case "Platinum":
                    if (DateTime.Now.AddHours(96) < date)
                        throw new Exception("Cannot create a reservation for a Platinum client with more than 96 hours of anticipation");
                    break;

                default:
                    throw new Exception("");
            }

            if (clientReservations.Where(c => c.Date.Date == Date.Date)
                                  .Count() > 0)
            {
                throw new Exception($"A reservation for client {client.Name} already exists in the same day");
            }

            this.ClientId = client.Id;
            this.TableId = table.Id;
            this.DaytimeId = daytime.Id;
            this.Date = date;
        }
    }
}
