using CZ.Domain;
using CZ.DTO;
using CZ.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Services
{
    public class ClientReservationService
    {
        ReservationRepository _reservationRepository;
        ClientRepository _clientRepository;
        TableRepository _tableRepository;
        DaytimeRepository _daytimeRepository;

        public ClientReservationService(ReservationRepository reservationRepository,
            ClientRepository clientRepository,
            TableRepository tableRepository,
            DaytimeRepository daytimeRepository)
        {
            this._reservationRepository = reservationRepository;
            this._clientRepository = clientRepository;
            this._tableRepository = tableRepository;
            this._daytimeRepository = daytimeRepository;
        }

        public async Task<string> CreateClientReservation(string clientKey, ReservationDto reservationDto)
        {
            try
            {
                var client = await _clientRepository.GetClient(Guid.Parse(clientKey));

                if (client == null)
                    throw new Exception("Client doesn't exist");

                var table = await this._tableRepository.GetById(reservationDto.Table.Id);

                var reservationsByClient = await _reservationRepository.GetClientReservationByClientId(client.Id);

                var clientReservation = new Reservation(reservationsByClient, client, table, await _daytimeRepository.GetById(1), reservationDto.Date);

                var clientReservationResult = this._reservationRepository.Add(clientReservation);
                this._reservationRepository.SaveChanges();

                return clientReservationResult.TableId.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
