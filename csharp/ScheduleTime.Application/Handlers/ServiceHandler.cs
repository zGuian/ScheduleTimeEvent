using AutoMapper;
using ScheduleTime.Application.Interfaces;
using ScheduleTime.CrossCutting.DTOs;
using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Factories;

namespace ScheduleTime.Application.Handlers
{
    public class ServiceHandler : IServiceHandler
    {
        private readonly IMapper _mapper = null!;
        private readonly IServiceServices _services = null!;


        private ServiceHandler() { }

        public ServiceHandler(IServiceServices services, IMapper mapper)
        {
            _mapper = mapper;
            _services = services;
        }

        public Task ScheduleATimeBarberShopAsync(ScheduleDTO scheduleDTO)
        {
            var barberShopFactory = new BarbershopFactory();
            var schedule = _mapper.Map<Schedule>(scheduleDTO);
            barberShopFactory.CreateSchedule(schedule.ScheduledTime, schedule.Customer);

            throw new NotImplementedException();
        }

        public Task ScheduleATimeBeuatySalonAsync(ScheduleDTO scheduleDTO)
        {
            var beautySalonFactory = new BeautySalonFactory();
            var schedule = _mapper.Map<Schedule>(scheduleDTO);
            beautySalonFactory.CreateSchedule(schedule.ScheduledTime, schedule.Customer);

            throw new NotImplementedException();
        }
    }
}
