﻿using Microsoft.AspNetCore.Mvc;
using ScheduleTime.Application.Interfaces;
using ScheduleTime.CrossCutting.DTOs.V1;

namespace ScheduleTime.Presentation.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/{controller}")]
    public class BeautySalonController : ControllerBase
    {
        private readonly IBeautySalonHandler _beautySalonHandler;

        private BeautySalonController()
        {
            if (_beautySalonHandler == null) throw new NullReferenceException();
        }

        public BeautySalonController(IBeautySalonHandler beautySalonHandler)
        {
            _beautySalonHandler = beautySalonHandler;
        }

        public async Task<IActionResult> ScheduleTime([FromBody] BeautySalonDTO beautySalonDTO)
        {
            await _beautySalonHandler.ScheduleTime(beautySalonDTO);

            throw new NotImplementedException();
        }
    }
}