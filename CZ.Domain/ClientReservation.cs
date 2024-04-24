using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain
{
    public class ClientReservation : BaseEntity
    {
        [Required]
        public Client Client { get; set; }
        [Required]
        public Reservation Reservation { get; set; }

        private ClientReservation() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientReservations">All reservations for the specified client</param>
        /// <param name="client"></param>
        /// <param name="reservation"></param>
        /// <exception cref="Exception"></exception>
        public ClientReservation(IList<ClientReservation> clientReservations, Client client, Reservation reservation)
        {
            switch (client.Category.Name)
            {
                case "Classic":
                    if (DateTime.Now.AddHours(48) < reservation.Date)
                        throw new Exception("Cannot create a reservation for a Classic client with more than 48 hours of anticipation");
                    break;

                case "Gold":
                    if (DateTime.Now.AddHours(72) < reservation.Date)
                        throw new Exception("Cannot create a reservation for a Gold client with more than 72 hours of anticipation");
                    break;

                case "Platinum":
                    if (DateTime.Now.AddHours(96) < reservation.Date)
                        throw new Exception("Cannot create a reservation for a Platinum client with more than 96 hours of anticipation");
                    break;

                default:
                    throw new Exception("");
            }

            if (clientReservations.Where(c => c.Reservation.Date.Date == reservation.Date.Date)
                                  .Count() > 0)
            {
                throw new Exception($"A reservation for client {client.Name} already exists in the same day");
            }

            this.Client = client;
            this.Reservation = reservation;
        }
    }
}
