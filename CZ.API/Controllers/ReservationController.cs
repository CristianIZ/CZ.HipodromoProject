using CZ.DTO;
using CZ.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CZ.API.Controllers
{
    [ApiController]
    public class ReservationController : Controller
    {
        ClientReservationService _clientReservationService;

        public ReservationController(ClientReservationService clientReservationService)
        {
            this._clientReservationService = clientReservationService;
        }

        [HttpPost("Create/{clientKey}")]
        public async Task<ActionResult> Create(string clientKey, [FromBody] ReservationDto reservationDto)
        {
            var result = await this._clientReservationService.CreateClientReservation(clientKey, reservationDto);

            return View(result);
        }
    }
}
