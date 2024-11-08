using ScheduleTime.Application.Handlers.Contracts;
using ScheduleTime.Application.Interfaces;
using ScheduleTime.CrossCutting.DTOs.V1;

namespace ScheduleTime.Application.Handlers
{
    public class BarberShopHandler : IBaseHandler<BarberShopDTO>, IBarberShopHandler
    {
        private readonly IBarberShopService _service;
        private readonly IBarberShopUseCase _useCase;

        public BarberShopHandler()
        {
            if (_service == null) throw new ArgumentNullException(nameof(_service));
            if (_useCase == null) throw new ArgumentNullException(nameof(_useCase));
        }
        public BarberShopHandler(IBarberShopService service, IBarberShopUseCase useCase)
        {
            _service = service;
            _useCase = useCase;
        }

        public Task ScheduleTime(BarberShopDTO barberShopDTO)
        {
            var barberShop = _useCase.ValidDataAndConvertDTOInEntity(barberShopDTO);

            throw new NotImplementedException();
        }
    }
}
