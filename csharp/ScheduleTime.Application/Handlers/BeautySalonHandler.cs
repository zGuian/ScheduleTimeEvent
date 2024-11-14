using ScheduleTime.Application.Interfaces;
using ScheduleTime.CrossCutting.DTOs.V1;
using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Responses;

namespace ScheduleTime.Application.Handlers
{
    public class BeautySalonHandler : IBeautySalonHandler
    {
        private readonly IBeautySalonService _service;
        private readonly IBeautySalonUseCase _useCase;

        private BeautySalonHandler()
        {
            if (_service == null) throw new NullReferenceException();
            if (_useCase == null) throw new NullReferenceException();
        }

        public BeautySalonHandler(IBeautySalonService beautySalonService, IBeautySalonUseCase beautySalonUseCase)
        {
            if (_service == null) throw new NullReferenceException();
            if (_useCase == null) throw new NullReferenceException();
            _service = beautySalonService;
            _useCase = beautySalonUseCase;
        }

        public async Task<ViewResponse<ScheduleDTO>> ScheduleTime(BeautySalonDTO beautySalonDto)
        {
            var beautySalon = _useCase.ValidDataAndConvertDTOInEntity(beautySalonDto);
            var availability = await _service.VerifyAvailability(beautySalon);
            if (!availability.IsValid)
            {
                // Retorna surgestão de horário novo
                var viewResponse = new ViewResponse<Schedule>(false, availability.Obj, 1, 
                    $"Surgestao de horario: {availability.Obj.ScheduledTime}");
                throw new NotImplementedException();
            }
            // Retorna horario agendado
            var viewResponse2 = new ViewResponse<Schedule>(true, availability.Obj, 1, 
                $"Horário confirmado: {availability.Obj.ScheduledTime}");
            throw new NotImplementedException();
        }
    }
}
