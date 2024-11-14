using ScheduleTime.Application.Interfaces;
using ScheduleTime.Application.Services.Contracts;
using ScheduleTime.DataBase.Interfaces;
using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Responses;

namespace ScheduleTime.Application.Services
{
    public class BeautySalonService : IBaseService<BeautySalon>, IBeautySalonService
    {
        private readonly IBeautySalonRepository _repository;

        public BeautySalonService()
        {
            if (_repository == null) throw new ArgumentNullException(nameof(_repository));
        }

        public BeautySalonService(IBeautySalonRepository repository)
        {
            _repository = repository;
        }

        public async Task<ObjectResponse<Schedule>> VerifyAvailability(BeautySalon beautySalon)
        {
            var response = await _repository.CheckIfTimeIsAvailableAsync(beautySalon.Schedule.ScheduledTime);
            if (!response.IsValid)
            {
                throw new NotImplementedException();
            }
            return new ObjectResponse<Schedule>(true, response.Obj);
        }
    }
}
