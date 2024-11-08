using ScheduleTime.Application.Handlers.Contracts;
using ScheduleTime.Application.Interfaces;
using ScheduleTime.CrossCutting.DTOs.V1;

namespace ScheduleTime.Application.Handlers
{
    public class BeautySalonHandler : IBaseHandler<BeautySalonDTO>, IBeautySalonHandler
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
            _service = beautySalonService;
            _useCase = beautySalonUseCase;
        }

        public Task ScheduleTime(BeautySalonDTO beautySalonDTO)
        {
            var beautySalon = _useCase.ValidDataAndConvertDTOInEntity(beautySalonDTO);



            throw new NotImplementedException();
        }
    }
}
