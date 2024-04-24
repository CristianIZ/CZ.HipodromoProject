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
        ClientReservationRepository _clientReservationRepository;
        ClientRepository _clientRepository;
        TableRepository _tableRepository;
        DaytimeRepository _daytimeRepository;

        public ClientReservationService(ReservationRepository reservationRepository,
            ClientReservationRepository clientReservationRepository,
            ClientRepository clientRepository,
            TableRepository tableRepository,
            DaytimeRepository daytimeRepository)
        {
            this._reservationRepository = reservationRepository;
            this._clientReservationRepository = clientReservationRepository;
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

                Reservation reservation = new Reservation(table, await _daytimeRepository.GetById(1), reservationDto.Date);

                var reservationsByClient = await _clientReservationRepository.GetClientReservationByClientKey(client);

                var clientReservation = new ClientReservation(reservationsByClient, client, reservation);

                var clientReservationResult = this._clientReservationRepository.Add(clientReservation);
                this._clientReservationRepository.SaveChanges();

                return clientReservationResult.Reservation.Table.Id.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
