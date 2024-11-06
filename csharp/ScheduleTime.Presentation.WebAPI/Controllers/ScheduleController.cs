using Microsoft.AspNetCore.Mvc;
using ScheduleTime.Application.Interfaces;
using ScheduleTime.CrossCutting.DTOs;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Presentation.WebAPI.Controllers
{
    [ApiController]
    [Route("/api/v1/Schedule")]
    public class ScheduleController : ControllerBase
    {
        private readonly IServiceHandler _handler;

        public ScheduleController(IServiceHandler handler)
        {
            _handler = handler;
        }

        public async Task<IActionResult> ScheduleATimeBarbershop(ScheduleDTO scheduleDTO)
        {
            await _handler.ScheduleATimeBarberShopAsync(scheduleDTO);

            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
